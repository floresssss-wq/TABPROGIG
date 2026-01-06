using System;
using System.Numerics;

namespace Tanques
{
    class NavegaComp
    {
        const float MAX_FORCE = 1.2f;
        const float CIRCLE_DISTANCE = 3F; // Aumentado para mais variação
        const float CIRCLE_RADIUS = 2F;
        const float ANGLE_CHANGE = 1.2F; // Aumentado de 0.5 para 1.2 para mais aleatoriedade

        public Vector2 navega;
        public Boid host;
        private float wanderAngle;
        private Random rnd;

        public NavegaComp(Boid h)
        {
            host = h;
            navega = new Vector2(0);
            wanderAngle = 0f;
            rnd = new Random(Guid.NewGuid().GetHashCode());
        }

        public void seek(Vector2 target) { navega += doSeek(target); }
        public void flee(Vector2 target) { navega += doFlee(target); }
        public void wander() { navega += doWander(); }

        private Vector2 doSeek(Vector2 target)
        {
            Vector2 position = host.getPosition();
            Vector2 velocity = host.getVelocity();
            Vector2 desejo = Vector2.Normalize(target - position) * host.getMaxVelocity();
            return desejo - velocity;
        }

        private Vector2 doFlee(Vector2 alvo)
        {
            Vector2 pos = host.getPosition();
            Vector2 velo = host.getVelocity();
            Vector2 desired = Vector2.Normalize(pos - alvo) * host.getMaxVelocity();
            return desired - velo;
        }

        public Vector2 doWander()
        {
            Vector2 velo = host.getVelocity();
            Vector2 circleCenter = velo.Length() == 0 ? new Vector2(CIRCLE_DISTANCE, 0) : Vector2.Normalize(velo) * CIRCLE_DISTANCE;

            Vector2 displacement = new Vector2(0, -1) * CIRCLE_RADIUS;
            wanderAngle += ((float)rnd.NextDouble() * ANGLE_CHANGE) - (ANGLE_CHANGE * 0.5f);

            float len = displacement.Length();
            displacement.X = (float)Math.Cos(wanderAngle) * len;
            displacement.Y = (float)Math.Sin(wanderAngle) * len;

            return circleCenter + displacement;
        }

        public void update()
        {
            float mag = navega.Length();
            if (mag > MAX_FORCE) navega = (navega / mag) * MAX_FORCE;

            navega = navega / host.getMass();
            Vector2 novaVelo = host.getVelocity() + navega;

            float velMag = novaVelo.Length();
            if (velMag > host.getMaxVelocity()) novaVelo = (novaVelo / velMag) * host.getMaxVelocity();

            host.setVelocity(novaVelo);
            host.setPosition(host.getPosition() + novaVelo);
            navega *= 0;
        }
    }
}