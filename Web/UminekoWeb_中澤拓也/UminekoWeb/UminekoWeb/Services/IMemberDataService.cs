using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    public interface IMemberDataService
    {
        // mender_nameとmender_codeを持ってくる
        public List<Member> GetList();
    }
}