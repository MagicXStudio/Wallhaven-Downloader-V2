namespace Wallhaven_Downloader_V2
{
    struct Collection
    {
        public string name;
        public int id;
        public string owner;

        public Collection(string name, int id, string owner)
        {
            this.name = name;
            this.id = id;
            this.owner = owner;
        }

        public string ToURL()
        {
            string base_url = $"https://wallhaven.cc/api/v1/collections/{owner}/{id}";
            return base_url;
        }
    }
}
