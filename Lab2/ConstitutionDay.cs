using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{

    class ConstitutionDay
    {
        static void Main(string[] args)
        {
            string amendment1 = "Congress shall make no law respecting an establishment of religion  or prohibiting the free exercise thereof, or abridging the freedom of speech or of the press, or the right of the people peaceably to assemble and to petition the government for a redress of grievances.";
            bool contain = amendment1.Contains("free exercise ");
            string amendment2 = "A well - regulated Militia being necessary to the security of a free State, the right of the people to keep and bear Arms shall not be infringed.";

            string amendment3 = "No soldier shall, in time of peace, be quartered in any house without the consent of the owner, nor in time of war but in a manner to be prescribed by law.";
            string upper = amendment3.ToUpper();
            Console.WriteLine(upper);
            string amendment4 = "The right of the people to be secure in their persons, houses, papers, and effects against unreasonable searches and seizures shall not be violated, and no warrants shall issue but upon probable cause, supported by oath or affirmation, and particularly describing the place to be searched and the persons or things to be seized.";

            string amendment5 = "No person shall be held to answer for a capital or otherwise infamous crime unless on a presentment or indictment of a grand jury, except in cases arising in the land or naval forces, or in the militia, when in actual service in time of war or public danger; nor shall any person be subject for the same offense to be twice put in jeopardy of life or limb; nor shall be compelled in any criminal case to be a witness against himself, nor be deprived of life, liberty, or property without due process of law; nor shall private property be taken for public use without just compensation.";

            string amendment6 = "In all criminal prosecutions, the accused shall enjoy the right to a speedy and public trial by an impartial jury of the state and district wherein the crime shall have been committed, which district shall have been previously ascertained by law, and to be informed of the nature and cause of the accusation; to be confronted with the witnesses against him; to have compulsory process for obtaining witnesses in his favor; and to have the assistance of counsel for his defense.";
            int length = amendment6.Length;
            Console.WriteLine(length);
            string amendment7 = "In suits at common law, where the value in controversy shall exceed twenty dollars, the right of trial by jury shall be preserved, and no fact tried by a jury shall be otherwise reexamined in any court of the United States than according to the rules of the common law.";

            string amendment8 = "Excessive bail shall not be required, nor excessive fines imposed, nor cruel and unusual punishments inflicted.";

            string amendment9 = "- Other Rights Kept by the PeopleThe enumeration in the Constitution of certain rights shall not be construed to deny or disparage others retained by the people.";
            string position = amendment9.Substring(44, 68);
            Console.WriteLine(position);
            string amendment10 = "The powers not delegated to the United States by the Constitution, nor prohibited by it to the states, are reserved to the states respectively, or to the people.";
            char char66 = amendment8[66];
            Console.WriteLine(char66);
        }
    }
}
