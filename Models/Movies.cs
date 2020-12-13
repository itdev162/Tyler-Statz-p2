namespace Api.Models{
    public class Movies{
        public Movies(int id, string title, int year){
            this.Id = id;
            this.Title = title;
            this.Tear = year;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}