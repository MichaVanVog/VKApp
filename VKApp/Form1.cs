using System.ComponentModel;
using System.Text.Json;
using System.Web;

namespace VKApp
{
    public partial class Vkontakte : Form
    {
        private readonly HttpClient client;
        private string TOKEN { get; set; } = "653fcbec653fcbec653fcbec426544ed556653f653fcbec04c298fb47fe9bca0f777fbb";
        private string Version { get; set; } = "5.131";

        private Group _group;
        private Group group { get { return _group; }
        set { _group = value; AvatarPictureBox.Load(_group.photo_200); GroupNameLabel.Text = _group.name; }
        }

        BindingList<User> users = new();

        public Vkontakte()
        {
            InitializeComponent();
            client = new HttpClient();
            UserDataGridView.DataSource = users;
        }

        public static string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);
            return JsonSerializer.Serialize(jsonElement, options);
        }

        public Task<HttpResponseMessage> VkGet(String method, Dictionary<String, String> parameters)
        {
            var builder = new UriBuilder($"https://api.vk.com/method/{method}");
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["access_token"] = TOKEN;
            query["v"] = Version;

            foreach (var key in parameters.Keys)
            {
                query[key] = parameters[key];
            }

            builder.Query = query.ToString();
            string url = builder.ToString();
            return client.GetAsync(url);
        }

        async void FetchGroupInfo()
        {
            HttpResponseMessage response = await VkGet("groups.getById", new Dictionary<string, string>
            {
                ["group_id"] = IdTextBox.Text,
                ["fields"] = "cover"
            });
            var content = await response.Content.ReadAsStringAsync();

            var vkResponse = JsonSerializer.Deserialize<Response<Group>>(content);
            this.group = vkResponse?.response?[0];
            ResponseRichTextBox.Text = PrettyJson(content);
        }

        async void FetchGroupMember()
        {
            HttpResponseMessage response = await VkGet("groups.getMembers", new Dictionary<string, string>
            {
                ["group_id"] = IdTextBox.Text,
                ["fields"] = "photo_200_orig",
                ["lang"] = "ru"
            }) ;
            var content = await response.Content.ReadAsStringAsync();

            var itemResponse = JsonSerializer.Deserialize<DictResponse<ItemResponse<User>>>(content);

            users.Clear();
            //foreach (var user in itemResponse.response.Items)
            //{
            //    users.Add(user);
            //}
            ResponseRichTextBox.Text = PrettyJson(content);
        }

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            FetchGroupInfo();
            FetchGroupMember();
        }
    }
}