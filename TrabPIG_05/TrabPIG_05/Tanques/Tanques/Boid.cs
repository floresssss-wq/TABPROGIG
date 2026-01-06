using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tanques
{
    interface Boid
    {
        Vector2 getVelocity();
        void setVelocity(Vector2 v);
        float getMaxVelocity();
        Vector2 getPosition();
        void setPosition(Vector2 p);
        int getMass();
        float getRaio();
        Rectangle getHitbox();

    }
}
