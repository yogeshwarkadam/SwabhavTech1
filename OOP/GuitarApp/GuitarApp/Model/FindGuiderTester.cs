using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    class FIndGuiderTester
    {
        public static void testErin()
        {
            Inventory inventory = new Inventory();

            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", "Fender", "Stratocastor", "electric", "Alder", "Alder", 0);
            Guitar guitar = inventory.Search(whatErinLikes);
            if (guitar != null)
            {
                string msgSuccess = "Found Guitar As Descriptions \n  We have " +
                  (guitar.GetBuilder() + " " + guitar.GetModel() + " " +
                    guitar.GetType() + " guitar:\n    " +
                    guitar.GetBackWood() + " back and sides,\n    " +
                    guitar.GetTopWood() + " top.\nYou can have it for only $" +
                    guitar.GetPrice() + "!\n----");

                Console.WriteLine(msgSuccess);
                Console.ReadKey();
            }
            else
            {
                string msgFail = "Sorry, Erin, we have nothing for you.";
                Console.WriteLine(msgFail);
                Console.ReadKey();
            }
        }


        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("11277", "Collings", "CJ", "acoustic", "Indian Rosewood", "Sitka", 3999.95);
            inventory.addGuitar("V95693", "Fender", "Stratocastor", "electric", "Alder", "Alder", 1499.95);
            inventory.addGuitar("V95210", "Fender", "Stratocastor", "electric", "Alder", "Alder", 1549.95);
            inventory.addGuitar("122784", "Martin", "D-18", "acoustic", "Mahogany", "Adirondack", 5495.95);
            inventory.addGuitar("76531", "Martin", "OM-28", "acoustic", "Brazilian Rosewood", "Adriondack", 6295.95);
        }
    }
}