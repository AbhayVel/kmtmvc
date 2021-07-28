using KmiEntities;
using KMIRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIService
{

    //Death of child object is dependent on Parent object. 
   public  class LoginUserService
    {
        public ISendRepository SendRepository { get; set; }
        public ILoginUserRepository LoginUserRepository { get; set; }
        public LoginUserService(ILoginUserRepository loginUserRepository, ISendRepository sendRepository) //Association
        {
            LoginUserRepository = loginUserRepository;

            SendRepository = sendRepository;

            SendRepository.Count = SendRepository.Count + 1;

           /// LoginUserRepository = new LoginUserRepository();  //composition 
        }


        public void SetLoginUserRepository(ILoginUserRepository loginUserRepository)
        {
            LoginUserRepository = loginUserRepository;
        }


        public LoginUser GetLoginUser(string userName)
        {


            LoginUser loginUser = LoginUserRepository.GetLoginUser(userName);



            return loginUser;
        }


    }
}
