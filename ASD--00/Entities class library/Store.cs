using System;
using System.Collections.Generic;
using System.Text;

namespace Entities_class_library
{
    internal class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Game> games { get; set; }

        public void AddGame(Game game)
        {
            if (games.Exists(g => !g.IsDeleted && g.Name == game.Name))
            {
             throw new AlreadyExistsException("artiq var");
            }     
            games.Add(game);
           
        }
        public void GetGameById(int? id)
        {

        }
        public void RemoveGameById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException();
            }
            
                
            
        }
        public void FilterGamesByPrice(double min,double max)
        {
            if ()
            {
                throw new 
            }
        }
        public void FilterGamesByDiscountedPrice(double min, double max)
        {

        }
       

    }
}
