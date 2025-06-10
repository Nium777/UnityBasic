using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banbokmoon : MonoBehaviour
{
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();

    }


    public void Phase1()
    {
        string star;
        star = string.Empty;
        
        for (int a = 1; a < 6; a++)
        {
            for (int b = 0; b < a; b++)
            {
                star += "¡Ú";
            }
            star += "\n";
            
        }
        Debug.Log(star);


    }

    public void Phase2()
    {
        string star;
        star = string.Empty;
        int e = 4;
        for (int c = 0; c < 5; c++)
        {
            star += "¡Ú";
        }
        star += "\n";
        for (int a = 0; a < 4; a++)
        {
            
            
            
            for (int d = 0; d < 5 - e; d++)
            {
                star += "¡¡";
            }
            e--;


            for (int b = 4; b > a; b--)
            {
                star += "¡Ú";
            }
            star += "\n";

        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        string star;
        star = string.Empty;

        for (int a = 1;a < 6;a++)
        {
            for(int b = 0;b < a;b++)
            {
                star += "¡Ú";
            }
            star += "\n";
            
        }
        for (int a = 1; a < 6; a++)
        {
            for (int b = 5; b > a; b--)
            {
                star += "¡Ú";
            }
            star += "\n";

        }
        Debug.Log(star);
    }

    public void Phase4()
    {
        string star;
        star = string.Empty;
        int e = 4;
        int g = 4;

        for (int a = 1; a< 5; a++)
        {
            for (int f = 0; f < g; f++)
            {
                star += "¡¡";
            }
            g--;

            for (int h = 0; h < a; h++)
            {
                star += "¡Ú";
            }

            star += "\n";
        }

        for (int c = 0; c < 5; c++)
        {
            star += "¡Ú";
        }
        star += "\n";

        for (int a = 0; a < 4; a++)
        {



            for (int d = 0; d < 5 - e; d++)
            {
                star += "¡¡";
            }
            e--;


            for (int b = 4; b > a; b--)
            {
                star += "¡Ú";
            }

            star += "\n";

        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        string star;
        star = string.Empty;

        for (int a = 0; a < 9; a++)
        {
            if (a == 0)
            {
                for (int b = 0; b < 4; b++)
                {
                    star += "¡¡";
                }
                star += "¡Ú";
                star += "\n";
            }

            else if (a == 1)
            {
                for (int b = 0; b < 3; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 3; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 2)
            {
                for (int b = 0; b < 2; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 5; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 3)
            {
                for (int b = 0; b < 1; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 7; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 4)
            {
                for (int c = 0; c < 9; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 5)
            {
                for (int b = 0; b < 1; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 7; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 6)
            {
                for (int b = 0; b < 2; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 5; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 7)
            {
                for (int b = 0; b < 3; b++)
                {
                    star += "¡¡";
                }

                for (int c = 0; c < 3; c++)
                {
                    star += "¡Ú";
                }
                star += "\n";
            }

            else if (a == 8)
            {
                for (int b = 0; b < 4; b++)
                {
                    star += "¡¡";
                }
                star += "¡Ú";
                star += "\n";
            }

        }
        Debug.Log (star);

    }

}
