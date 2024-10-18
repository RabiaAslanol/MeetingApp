namespace MeetingApp.Models{
    public static class Respository{
        private static List<UserInfo>_users=new();
        static Respository(){
            _users.Add(new UserInfo(){Id=1, Name="Kübra",Email="kub@gmail.com",Phone="213454654",WillAttend=false});
            _users.Add(new UserInfo(){Id=2, Name="İrem",Email="irem@gmail.com",Phone="135456121",WillAttend=true});
            _users.Add(new UserInfo(){Id=3, Name="Rabia",Email="rabia@gmail.com",Phone="798413548",WillAttend=true});
        }
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }
        public static void CreateUsers(UserInfo user){
            user.Id=Users.Count+1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(user=> user.Id==id);
        }
    }
}