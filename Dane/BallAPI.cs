﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class BallAPI
    {
        public abstract Vector2 getPosition();
        public abstract void setPosition(float x, float y);
        public abstract void setSpeed(float x, float y);
        public abstract Vector2 getSpeed();
        public abstract int getR();


        public abstract event EventHandler<DataEventArgs> ChangedPosition;

        public static BallAPI CreateBall(float X, float Y, float xSpeed, float ySpeed, int radius)
        {
            return new Ball(new Vector2(X, Y), radius, new Vector2(xSpeed, ySpeed));
        }
        public abstract void MakeMove(int width, int height);

        public void RaisePropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }


}