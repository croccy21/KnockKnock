using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KnockKnock.Scripts.BackEnd
{
    public delegate void OnOpenHandler();

    public class House
    {
        private int houseNumber;
        private OnOpenHandler openHandler;
        private bool isGood;

        public House(int houseNumber, bool isGood, OnOpenHandler openHandler)
        {
            this.houseNumber = houseNumber;
            this.isGood = isGood;
            this.openHandler = openHandler;
        }

        public int Number
        {
            get
            {
                return houseNumber;
            }
        }

        public bool IsGood
        {
            get
            {
                return isGood;
            }
        }

        public void Open()
        {
            openHandler();
        }
        
        public House Next(HouseGenerator generator)
        {
            throw new NotImplementedException();
        }
    }
}