


namespace _Task_Seachien_3_
{


    class Book
    {

        public string Title;
        public string Author;
        public int isbn;
        public bool availability = true;

        public Book(string title, string author, int isbn, bool availability) // هنا دة الكونستراكنور يعنى اى يعنى اول منا باخد اوبجيكت من نوع البوك بيطلب منى اديلو الصفا تالى مطلوبة
        {
            this.Title = title;
            this.Author = author;
            this.isbn = isbn;
            this.availability = availability;
        }
    }
    class libary
    {
        List<Book> books = new List<Book>();
        int counts = 0;
        public void AddBooks() // هنا دة ميثود الاضافة بحيث انى انا لو احتاجت انى اضيف اى كتاب جديد اندة على الميثود ادخل البيانات المطلوبة ويضاف الكتاب عندى فى  السيستم على طول
        {
            Console.Write("Enter Book Title  : ");
            string title = Console.ReadLine();
            Console.Write("Enter Book Author : ");
            string author = Console.ReadLine();
            Console.Write("Enter Book ISBN   : ");
            int isbn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Availability  : ");
            bool availability = Convert.ToBoolean(Console.ReadLine());
            books.Add(new Book(title, author, isbn, availability));
            counts++;
        }
        public void SearchBooks(string author)// \\ الفانكشان دة بتاعت البحث عن اى كتاب ادخ اسم الكتاب او اسم المؤلف يطلعلى كل حاجة عنو
        {
            bool found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Author == author)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            if (found == true)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Author == author)
                    {
                        Console.WriteLine("Book Found");
                        Console.WriteLine($"Title         : {books[i].Title}");
                        Console.WriteLine($"Author        : {books[i].Author}");
                        Console.WriteLine($"Isbn          : {books[i].isbn}");
                        Console.WriteLine($"availability  : {books[i].availability}");
                        Console.WriteLine("================");
                    }
                }

            }
            else { Console.WriteLine("Book Not Found"); }
        }
        public bool BorrowBook(string title) // الفانكشان دة بتشوفلى هل الكتاب دة مستعار ولا موجود 
        {
            bool found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books[i].availability = false;
                    found = true;
                    Console.WriteLine("The Book Borrow");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("The Book Not Borrow");
            }
            return found;
        }

        public void ReturnBook(string title) //الفانكشان دة بتشوفلى هل الكتاب دة رجع ولا لسة مستعار
        {
            bool found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books[i].availability = true;
                    found = true;

                    Console.WriteLine("The Book Return");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("The Book Not Return");
            }

        }
        public void display() // الفانكشان دة بتطبعلى كل الكتب الى موجودة فى المكتبة ببياناتهم و عددهم كام 
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Name Author  : {books[i].Author}");
                Console.WriteLine($"Name Title   : {books[i].Title}");
                Console.WriteLine($"isbn         : {books[i].isbn}");
                Console.WriteLine($"Availability : {books[i].availability}");
                Console.WriteLine("================");
            }
            Console.WriteLine($"Count of Book is :{counts}");
        }
    


    
        static void Main(string[] args)
        {

            int chose;
            Book b = new Book("Pyramids", "Zeyad", 2222, true);
            libary l = new libary();

            do
            {

                Console.WriteLine("1- Add Book");
                Console.WriteLine("2- Search Book");
                Console.WriteLine("3- Borrow Book");
                Console.WriteLine("4- Return Book");
                Console.WriteLine("5- Dispaly Book");
                Console.WriteLine("6- Exit");
                Console.Write("Chose : ");
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        l.AddBooks();
                        break;
                    case 2:

                        Console.Write("Enter Author Name : ");
                        string author = Console.ReadLine();
                        l.SearchBooks(author);
                        break;
                    case 3:
                        Console.Write("Enter Title Of Book : ");
                        string title = Console.ReadLine();
                        l.BorrowBook(title);
                        break;
                    case 4:
                        Console.Write("Enter Title Of Book : ");
                        string title1 = Console.ReadLine();
                        l.ReturnBook(title1);
                        break;
                    case 5:
                        l.display();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Chose");
                        break;
                }
                Console.WriteLine("================");

            } while (chose != 0);
        }
    } 
}

