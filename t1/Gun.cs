using System;
using System.Collections.Generic;
using System.Text;

namespace t1_
{
    class Gun
    {
        private int bulletCount;
        public int BulletCount 
        {
            get
            {
                return bulletCount;
              

                

            } 
            set 
            {
                bulletCount = value;
                return;

            } 
        }

        public int GunReloadOneByOne() 
        {
            if (bulletCount!=30)
            {
                bulletCount++;
            }
            else
            {
                Console.WriteLine("Magazine full");
                
            }
            return bulletCount;

        }
        public int GunReload() 
        {
            if (bulletCount!=30)
            {
                bulletCount = 30;
                
            }
            return bulletCount;

        }
        public int ShootingOneByOne() 
        {
            
            if (bulletCount<=30 && bulletCount>0)
            {
                bulletCount--;
            }
            else
            {
                Console.WriteLine("You Havnt got a bullet in Magazine");
            }
            return bulletCount;

        }
        public int ShootingAuto() 
        {
            if (bulletCount<=30 && bulletCount>0 )
            {
                
                bulletCount = 0;

            }
            else
            {
                Console.WriteLine("You Havnt got a bullet in Magazine");
            }
            return bulletCount;


        }


    }










}



        




















        
   
    
