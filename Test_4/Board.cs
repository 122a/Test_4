using System;

namespace Test_4
{
    public class Board
    {
        static void Main(string[] args)
        {
/*            Board board = new Board(10);

            board.AddPost("첫 번째 게시글", "안녕하세요. 첫 번째 게시글입니다.", "작성자1");
            board.AddPost("두 번째 게시글", "안녕하세요. 두 번째 게시글입니다.", "작성자2");

            Board.Post[] posts = board.GetPosts();
            foreach (Board.Post post in posts)
            {
                Console.WriteLine($"제목: {post.Title}");
                Console.WriteLine($"작성자: {post.Author}");
                Console.WriteLine($"작성 시간: {post.PostedTime}");
                Console.WriteLine($"내용: {post.Content}");
                Console.WriteLine();
            }*/
        }

        private Post[] posts;
        private int postCount;

        // 게시글 클래스
        public class Post
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime PostedTime { get; set; }
            public string Author { get; set; }

            public Post(string title, string content, DateTime postedTime, string author)
            {
                Title = title;
                Content = content;
                PostedTime = postedTime;
                Author = author;
            }
        }

        public Board(int capacity)
        {
            posts = new Post[capacity];
            postCount = 0; 
        }

        // 게시글 추가 메서드
        public void AddPost(string title, string content, string author)
        {
            Post post = new Post(title, content, DateTime.Now, author);
            posts[postCount] = post;
            postCount++;
        }

        // 게시글 목록 가져오기 메서드
        public Post[] GetPosts()
        {
            Post[] result = new Post[postCount];
            for (int i = 0; i < postCount; i++)
            {
                result[i] = posts[i];
            }
            return result;
        }
    }
}
