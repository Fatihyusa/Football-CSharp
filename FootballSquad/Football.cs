using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSquad
{
    internal class Football
    {
        public Random raiting = new Random();
        protected string name, position;
        protected int kitNmbr, speed, durability, pass, shoot, skill, form;

        public Football(string name, string position, int kitNmbr)
        {
            speed = raiting.Next(20, 100);
            durability = raiting.Next(20, 100);
            pass = raiting.Next(20, 100);
            shoot = raiting.Next(20, 100);
            skill = raiting.Next(20, 100);
            form = raiting.Next(20, 100);
        }

        public Football()
        {

        }

        public virtual Boolean Pass()
        {
            int quickPass = Convert.ToInt32(pass * .3 + skill * .7 + durability * .5);

            if (quickPass > 85)
                return true;
            else
                return false;
        }

        public virtual Boolean Shoot() 
        {
            int GoalShoot = Convert.ToInt32(shoot * .1 + speed * .2);

            if(GoalShoot > 90)
                return true;
            else
                return false;
        }

        public virtual Boolean Skill()
        {
            int Skill = Convert.ToInt32(skill * .1);

            if(Skill> 10) 
                return true;
            else 
                return false;
        }
    }

    class Defanse : Football 
    {
        private int takingPosition, headBall, jumping, longPass;

        public Defanse(string name, string position, int kitNmbr) 
        {
            this.name = name;
            this.kitNmbr = kitNmbr;
            this.position = position;

            speed = raiting.Next(20, 100);
            durability = raiting.Next(20, 100);
            pass = raiting.Next(20, 100);
            shoot = raiting.Next(20, 100);
            skill = raiting.Next(20, 100);
            form = raiting.Next(20, 100);
            takingPosition = raiting.Next(20, 100);
            longPass = raiting.Next(20, 100);
            headBall = raiting.Next(20, 100);
            jumping = raiting.Next(20, 100);
        }
        public override Boolean Pass()
        {
            int quickPass = Convert.ToInt32(pass * .5 + skill * .2 + durability * .7 + longPass * .4 + takingPosition * .4 + jumping * .3);

            if (quickPass > 65)
                return true;
            else
                return false;
        }

        public override Boolean Shoot()
        {
            int GoalShoot = Convert.ToInt32(shoot * .4 + speed * .4 + headBall * .5 + jumping * .5);

            if (GoalShoot > 80)
                return true;
            else
                return false;
        }

        public override Boolean Skill()
        {
            int Skill = Convert.ToInt32(skill * .2);

            if (Skill > 15)
                return true;
            else
                return false;
        }
    }


    class Midfielder : Football 
    {
        private int longPass, productivity, dribbling, prvSkill;

        public Midfielder(string name, string position, int kitNmbr)
        {
            this.name = name;
            this.kitNmbr = kitNmbr;
            this.position = position;

            speed = raiting.Next(20, 100);
            durability = raiting.Next(20, 100);
            pass = raiting.Next(20, 100);
            shoot = raiting.Next(20, 100);
            skill = raiting.Next(20, 100);
            form = raiting.Next(20, 100);
            longPass = raiting.Next(20, 100);
            productivity = raiting.Next(20, 100);
            dribbling = raiting.Next(20, 100);
            prvSkill = raiting.Next(20, 100);
        }

        public override Boolean Pass()
        {
            int quickPass = Convert.ToInt32(pass * .7 + skill * .5 + durability * .7 + longPass * .7 + form * .6);

            if (quickPass > 10)
                return true;
            else
                return false;
        }

        public override Boolean Shoot()
        {
            int GoalShoot = Convert.ToInt32(shoot * .4 + speed * .4);

            if (GoalShoot > 95)
                return true;
            else
                return false;
        }

        public override Boolean Skill()
        {
            int Skill = Convert.ToInt32(skill * .2 + productivity * .5 + dribbling * .8 + prvSkill * .7 + form * .5);

            if (Skill > 15)
                return true;
            else
                return false;
        }
    }

    class Forward : Football 
    {
        private int finishing, head, prvSkill, cool;

        public Forward(string name, string position, int kitNmbr)
        {
            this.name = name;
            this.kitNmbr = kitNmbr;
            this.position = position;

            speed = raiting.Next(20, 100);
            durability = raiting.Next(20, 100);
            pass = raiting.Next(20, 100);
            shoot = raiting.Next(20, 100);
            skill = raiting.Next(20, 100);
            form = raiting.Next(20, 100);
            finishing = raiting.Next(20, 100);
            head = raiting.Next(20, 100);
            cool = raiting.Next(20, 100);
            prvSkill = raiting.Next(20, 100);
        }

        public override Boolean Pass()
        {
            int quickPass = Convert.ToInt32(pass * .5 + skill * .4 + durability * .7);

            if (quickPass > 20)
                return true;
            else
                return false;
        }

        public override Boolean Shoot()
        {
            int GoalShoot = Convert.ToInt32(shoot * .4 + speed * .4 + durability * .7 + cool * .8 + finishing * .8 + head * .7 + form * .7);

            if (GoalShoot > 95)
                return true;
            else
                return false;
        }

        public override Boolean Skill()
        {
            int Skill = Convert.ToInt32(skill * .2 + prvSkill * .7);

            if (Skill > 15)
                return true;
            else
                return false;
        }
    }

}
