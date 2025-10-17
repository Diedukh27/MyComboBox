using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class adad
    {
        public class Animal : IComparable<Animal>
        {
            private string _name;
            private ushort _age;
            private ex _sex;

            public Animal()
            {
                _name = "No name";
                _age = 0;
                _sex = Sex.Unknown;
            }

            public Animal(string name, ushort age, Sex sex)
            {
                _name = name;
                _age = age;
                _sex = sex;
            }

            public int CompareTo(Animal? other)
            {
                if (other == null) return 1;
                return _name.CompareTo(other._name);
            }

            public override bool Equals(object? obj)
            {
                if (obj is not Animal other) return false;
                return _name == other._name;
            }

            public override int GetHashCode()
            {
                return _name.GetHashCode();
            }

            public override string ToString()
            {
                string sex = _sex switch
                {
                    Sex.Female => "Дівчинка",
                    Sex.Male => "Хлопчик",
                    _ => "Не значена"
                };

                return $"{_name}\t{_age}\t{sex}";
            }
        }

    }
}
