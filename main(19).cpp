#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int n;
    cin >> n;
    int ciag[n];
    int wyniki[n];
  
    for(int i = 0; i < n; i++) {
        int a;
        cin >> a;
        ciag[i] = a;
    }
    
    sort(ciag, ciag + n);

    int index = 0; 

    for(int i = 0; i < n; i++) {
        int temp = ciag[i];
        int count = 1; 
        while (i + 1 < n && ciag[i] == ciag[i + 1]) {
            count++; 
            i++; 
        }
        wyniki[index] = count; 
        index++; 
    }
    
    int result = 0;
    
    for(int j = 0; j < index; j++){
        if(wyniki[j] >= 2){
            result++;
        }
    }
    
    cout<< result;
    return 0;
}
