using StateMethodDesignPattern;

Document document = new Document();
document.Request(); 

document.ChangeState(new ReviewState());
document.Request(); 

document.ChangeState(new PublishedState());
document.Request();