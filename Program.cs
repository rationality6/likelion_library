Library library = new Library();

library.ImportBookWithNextId(new Book("나는 왜 너가아닌가", "류시화"));
library.ImportBookWithNextId(new Book("돈키호테", "세르반데스"));
library.ImportBookWithNextId(new Book("돈키호테", "세르반데스", true));

library.ShowBookList();

library.SearchBooks("돈키호테");

library.SearchBooks("돈키호테", true);

library.FindRentingBooks(false);