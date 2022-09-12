using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaFilmów
{
    class Model : ObservableCollection<Film>
    {
        
        
        public ObservableCollection<Film> ListaFilmów { get; set; } = new ObservableCollection<Film>(new Film[]{
            new Film(){Tytul="Czarny telefon",Rezyser="Scott Derrickson",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("24.06.2022")},
            new Film(){Tytul="Yang",Rezyser="Kogonada",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("1.07.2022")},
            new Film(){Tytul="Hocus Pocus 2",Rezyser="Adam Shankman",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("15.09.2022")},
            new Film(){Tytul="Rzut życia",Rezyser="Jeremiah Zagar",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("8.06.2022")}
        });

        internal Film NowyFilm()
        {
            
                
                
                Film nowy = new Film(); 
                ListaFilmów.Add(nowy);
                return nowy;
            
            
           
        }
    }
}

