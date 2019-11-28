#define MULTIPLE_PROBES
#define DATA_PIN        D6

#include "mbed.h"
#include "DS1820.h"
#include <math.h>

#define MAX_PROBES      16
 
DS1820* probe[MAX_PROBES];
AnalogIn ain(A0);
DigitalOut rele(D10);
Serial pc(USBTX,USBRX);
DigitalOut myled(LED2);

int main() {  
    float Rntc;
    float i;
    
    // Initialize the probe array to DS1820 objects
    int num_devices = 0;
    while(DS1820::unassignedProbe(DATA_PIN)) {
        probe[num_devices] = new DS1820(DATA_PIN);
        num_devices++;
        if (num_devices == MAX_PROBES)
            break;
    }

    while(1) {
        float Uout = ain.read()*3.3;
        Rntc = 10*((3.3/Uout)-1);
        i = 3.3 / ( 10 + Rntc );        
        int t = (1.042*pow(10.0f,-5.0f)*pow(Rntc,6.0f)) - (9.749*pow(10.0f,-4.0f)*pow(Rntc,5.0f)) +
        (3.608*pow(10.0f,-2.0f)*pow(Rntc,4.0f)) - (6.751*pow(10.0f,-1.0f)*pow(Rntc,3.0f)) +
        (6.808*pow(Rntc,2.0f)) - (3.803*10*Rntc) + (1.272*pow(10.0f,2.0f));
        probe[0]->convertTemperature(true, DS1820::all_devices);         //Start temperature conversion, wait until ready
        for (int i = 0; i<num_devices; i++)
            pc.printf("%i,%3.1f\r\n", t, probe[i]->temperature());
        
        char temp;
        int itemp;
        if(pc.readable())
        {
            myled = 1;
            temp = pc.getc();
            itemp = (int)temp;
        }
        
        if(itemp == 49)
            {
                rele = 1;
            }
        else
            {
                rele = 0;
            }
    }
    
}