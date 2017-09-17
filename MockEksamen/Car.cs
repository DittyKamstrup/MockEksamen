using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{

    public enum Color { Black, White, Gray, Red, Green, Blue }
    public class Car
    {
        //INSTANS FIELDS
        private Color _color;

        //PROPERTIES
        public int Doors { get; set; }
          
        //Til håndtering af ændring af variabel, ikke fuldent
        //{
            //get { return door; }
            //set {
            //    if (door > 5 || door < 2)
            //    {
            //        throw new ArgumentOutOfRangeException("Der kan være mellem 2 til 5 døre!");
            //    }
            //    door = value; }
        //}

        public string Model { get; set; }
        public string RegistrationNo { get; set; }
        public Owner _owner { get; set; }

        /// <summary>
        /// CONSTRUCTOR UDEN OWNER
        /// </summary>
        /// <param name="color"></param>
        /// <param name="doors"></param>
        /// <param name="model"></param>
        /// <param name="registrationNo"></param>
        public Car(Color color, int doors, string model, string registrationNo)
        {
            _color = color;
            Doors = doors;
            Model = model;
            RegistrationNo = registrationNo;
        }

        /// <summary>
        /// OVERLOADING CONSTRUCTOR MED OWNER
        /// </summary>
        /// <param name="color"></param>
        /// <param name="doors"></param>
        /// <param name="model"></param>
        /// <param name="registrationNo"></param>
        /// <param name="owner"></param>
        public Car(Color color, int doors, string model, string registrationNo, Owner owner)
        {
            _color = color;
            Doors = doors;
            Model = model;
            RegistrationNo = registrationNo;
            _owner = owner;


            switch (color)
            {
                case Color.Black: break;
                case Color.Blue: break;
                case Color.Gray: break;
                case Color.Green: break;
                case Color.Red: break;
                case Color.White: break;

                default: throw new ArgumentOutOfRangeException("Kan kun indskrive følgende farver: Black, Blue, Gray, Green, Red, White!");
            }

            if (doors > 5 || doors < 2)
            {
                throw new ArgumentOutOfRangeException("Der kan være mellem 2 til 5 døre!");
            }

            if (model.Equals(null))
            {
                throw new NullReferenceException("Model skal angives!");
            }

            if (registrationNo.Length < 7 || registrationNo.Length > 7)
            {
                throw new ArgumentOutOfRangeException("Registrerings nr skal være på 7 tegn!");
            }
        }

    }
}
