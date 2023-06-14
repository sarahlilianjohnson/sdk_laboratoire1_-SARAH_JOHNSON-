using LibrairieConversionNote;

//la conversion de note continue jusqu'a la personne tappe CTRL + C
while (true)
{
    Console.Write("Type de conversion à faire : ");
    var input = Console.ReadLine();

    //Si l'utilisateur tape note
    if (input?.ToUpperInvariant() == "NOTE")
    {
        //un boucle pour la conversion de note 
        while (true)
        {
            Console.Write("Conversion à faire : ");
            var note = Console.ReadLine();
            string noteRetour = LibrairieConversionNote.ConversionAlphabetiqueToNote.Transform(note.ToUpper());
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
}