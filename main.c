/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

char cube[3][3][3];
int x, y, z, r;
void dig();

int main()
{
    srand(time(NULL));

    for(int a = 0; a < 3; a++)
    {
         for(int b = 0; b < 3; b++)
         {
              for(int c = 0; c < 3; c++)
              {
                 
                  r = rand() %3 + 1;
                  if (r == 1)
                  {
                      cube[a][b][c] = 'g';
                      printf("g");
                  }
                  else if(r == 2)
                  {
                      cube[a][b][c] = 'z';
                      printf("zilver");
                  }
                  else
                  {
                     cube[a][b][c] =  'e';
                     printf("skill issue");
                  }
                   
              }
         }
    }
    while(1)
    {
    printf("x waarde?");
    scanf("%i", &x);
    
    printf("y waarde?");
    scanf("%i", &y);
    
    printf("z waarde?");
    scanf("%i", &z);
    
    dig(x, y, z);
    }
    
    
}

void dig(x_guess, y_guess, z_guess)
{
    if (cube[x_guess][y_guess][z_guess] == 'g')
    {
        printf("GOUD");
    }
    else if (cube[x_guess][y_guess][z_guess] == 'z')
    {
        printf("ZILVER");
    }
    else
    {
        printf("DA'S JAMMER SKILL ISSUE");
    }
}
