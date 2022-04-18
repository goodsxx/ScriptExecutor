namespace ScriptExecutor.Dto
{
    public class WebHookInDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Committer
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class CommitsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tree_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> parent_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string distinct { get; set; }
        /// <summary>
        /// 这是一条测试 Push 类型 WebHook 触发的推送
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Committer committer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string added { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string removed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> modified { get; set; }
    }

    public class Author
    {
        /// <summary>
        /// 
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }
    public class Head_commit
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tree_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> parent_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string distinct { get; set; }
        /// <summary>
        /// 这是一条测试 Push 类型 WebHook 触发的推送
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Committer committer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string added { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string removed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> modified { get; set; }
    }

    public class Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public string login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string html_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string site_admin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Repository
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string full_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Owner owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @private { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string html_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pushed_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ssh_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string clone_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string svn_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_http_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_ssh_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_svn_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string homepage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stargazers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int watchers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int forks_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_issues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_wiki { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_pages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string license { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int open_issues_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string default_branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @namespace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name_with_namespace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path_with_namespace { get; set; }
    }

    public class Project
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string full_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Owner owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @private { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string html_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pushed_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ssh_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string clone_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string svn_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_http_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_ssh_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_svn_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string homepage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stargazers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int watchers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int forks_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_issues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_wiki { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_pages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string license { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int open_issues_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string default_branch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @namespace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name_with_namespace { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path_with_namespace { get; set; }
    }

    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Pusher
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Sender
    {
        /// <summary>
        /// 
        /// </summary>
        public string login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string html_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string site_admin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Enterprise
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string @ref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string before { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string after { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string compare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CommitsItem> commits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Head_commit head_commit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total_commits_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commits_more_than_ten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Repository repository { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Project project { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pusher pusher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sender sender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Enterprise enterprise { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hook_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int hook_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hook_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sign { get; set; }
    }
}
