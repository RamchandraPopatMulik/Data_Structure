﻿namespace Collection
{
    public class Program
    { 
    
        static void Main(string[] args)
        {
            LinkdedList linkdedList = new LinkdedList();
            linkdedList.Add(56);
            //linkdedList.Add(30);
            linkdedList.Add(70);
            linkdedList.InsertAtParticularPosition(2,30);
            linkdedList.Display();
        }
    }
}