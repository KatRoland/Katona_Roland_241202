using Katona_Roland_241202;

List<Book> books = new List<Book>
{
    new Book
    (
        1234567890,
        new List<Author> { new Author("Kovács Péter") },
        "Az Időutazó Naplója",
        2015,
        "magyar",
        7,
        2000
    ),
    new Book
    (
        1234567891,
        new List<Author> { new Author("John Smith") },
        "The Time Traveler's Journal",
        2018,
        "angol",
        0,
        3500
    ),
    new Book
    (
        1234567892,
        new List<Author> { new Author("Tóth Ágnes"), new Author("Kiss Anna") },
        "Történetek az Éjszakából",
        2012,
        "magyar",
        6,
        4500
    ),
    new Book
    (
        1234567893,
        new List<Author> { new Author("Szabó Márton") },
        "Rejtett Kincsek Nyomában",
        2020,
        "magyar",
        0,
        6000
    ),
    new Book
    (
        1234567894,
        new List<Author> { new Author("Farkas Éva") },
        "A Végtelen Lehetőségek",
        2022,
        "magyar",
        5,
        7000
    ),
    new Book
    (
        1234567895,
        new List<Author> { new Author("Nagy László") },
        "Nyári Zápor",
        2009,
        "magyar",
        9,
        9000
    ),
    new Book
    (
        1234567896,
        new List<Author> { new Author("Laura Anderson"), new Author("Emily Johnson") },
        "Summer Rain",
        2016,
        "angol",
        8,
        8000
    ),
    new Book
    (
        1234567897,
        new List<Author> { new Author("Robert Wilson") },
        "The Perfect Plan",
        2023,
        "angol",
        5,
        4000
    ),
    new Book
    (
        1234567898,
        new List<Author> { new Author("Molnár Anita") },
        "Történelmi Legendák",
        2011,
        "magyar",
        7,
        10000
    ),
    new Book
    (
        1234567899,
        new List<Author> { new Author("Varga Béla") },
        "A Misztikus Erdő",
        2019,
        "magyar",
        9,
        3000
    ),
    new Book
    (
        1234567810,
        new List<Author> { new Author("Papp Réka") },
        "Digitális Álom",
        2013,
        "magyar",
        0,
        6500
    ),
    new Book
    (
        1234567811,
        new List<Author> { new Author("Michael Brown"), new Author("Jessica Moore"), new Author("Thomas Taylor") },
        "Digital Dreams",
        2017,
        "angol",
        6,
        5000
    ),
    new Book
    (
        1234567812,
        new List<Author> { new Author("Takács Attila") },
        "A Titkos Recept",
        2021,
        "magyar",
        7,
        2500
    ),
    new Book
    (
        1234567813,
        new List<Author> { new Author("Németh Eszter") },
        "Az Ismeretlen Varázsló",
        2010,
        "magyar",
        0,
        7000
    ),
    new Book
    (
        1234567814,
        new List<Author> { new Author("Horváth Zoltán") },
        "Zenei Inspirációk",
        2007,
        "magyar",
        8,
        5500
    )
};

if(books.DistinctBy(e => e.getISBN()).Count() != books.Count())
{
    throw new ArgumentException("Nem lehet ISBN szám ismétlődés!");
}

int bevetel = 0;
int eladott = 0;
Random rnd = new Random();

int kezdetiossz = books.Sum(e => e.getKeszlet());

for ( int i = 0; i < 100; i++ )
{
    int bookId = rnd.Next(0,books.Count);
    Book randombook = books[bookId];
    if(randombook.getKeszlet() > 0)
    {
        bevetel += randombook.getAr();
        eladott++;
        books[bookId].setKeszlet(randombook.getKeszlet() - 1);
    } else
    {
        int chance = rnd.Next(1, 101);
        if(chance > 50)
        {
            books[bookId].setKeszlet(rnd.Next(1, 11));
        } else
        {
            books.RemoveAt(bookId);
        }
    }
}

int vegso = books.Sum(e => e.getKeszlet());


Console.WriteLine($"Bevétel összesen: {bevetel}\n" +
    $"A nagykerben {Math.Abs(books.Count() - 15)}db könyv fogyott ki\n" +
    $"Kezdeti készlet: {kezdetiossz}\n" +
    $"Végső készlet: {vegso}\n" +
    $"Különbség: {vegso-kezdetiossz}");


Book rand = new Book("Hajdú Beáta", "Egy réti kecske");

Console.WriteLine(books.Count);

