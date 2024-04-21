using Composite_Pattern.Example_1;
using Composite_Pattern.Example_2;
using File = Composite_Pattern.Example_2.File;

RunExample1();

static void RunExample1()
{
    var rootBox = new CompositeGift("RootBox", 0);

    var plainToy = new SingleGift("PlainToy", 255);
    var carToy = new SingleGift("CarToy", 145);

    rootBox.Add(plainToy);
    rootBox.Add(carToy);

    var childBox = new CompositeGift("ChildBox", 0);
    var soldierToy = new SingleGift("SoldierToy", 111);
    childBox.Add(soldierToy);

    rootBox.Add(childBox);

    Console.WriteLine($"Total Price of Gifts: {rootBox.CalculateTotalPrice()}");
}

static void RunExample2()
{
    var textFile = new File("Resume.docx", 105);
    var resumeFolder = new Folder("Resumes", 0);
    resumeFolder.Add(textFile);

    var mediaFile = new File("Video.mp4", 1000);
    var mediaFolder = new Folder("Videos", 0);
    mediaFolder.Add(mediaFile);

    var rootFolder = new Folder("Root", 0);
    rootFolder.Add(mediaFolder);
    rootFolder.Add(resumeFolder);

    rootFolder.CalculateSize();
}