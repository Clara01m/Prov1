using System;
using System.Collections.Generic;

namespace Prov
{
    public class Customer
    {
        static int money= 0; 
        //They need to be able to pay or sell
        static Random generate= new Random(); 
        //this might come in usefull to generate money or items
        static int intrest =0; 
        //how interessed they are in different products
        public List<int> ownedBooks =new List<int>();
        //pre-owned books
        public bool purchase=true; 
         // to see if the customer is purchasing/ selling the item in question
        public Customer()
        {

        } 
        //starting the instance? in english (instans)
        public void Guess()
        {

        }
        //to guess the price/ haggling back and forth
       
       

    }
}
