#include <stdio.h>

int main() {
  /* code */
  int lijstje[10] = {'c' , 'f' , 'n', 'i' , 'g' , 'e' , 'q' , 'a' ,'b', 'v'};

for (int j = 0; j < 9; j++){
  for (int i = 0; i < 9; i++) {
    if (lijstje[i] > lijstje[1+i]) {
      int backupje = lijstje[i];
      lijstje[i] = lijstje[i+1];
      lijstje[i +1] = backupje;
  }
}
}

  // negeer dit is voor tom
  for (int i = 0; i < 10; i++) {
    printf("%c\n", lijstje[i]);
  }

  return 0;
}

