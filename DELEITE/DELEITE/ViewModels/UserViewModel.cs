
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using DELEITE.Models;
using Xamarin.Forms;

namespace DELEITE.ViewModels
{
    public class UserViewModel : BaseViewModel
    { 
        public UserRole MyUserRole { get; set; }

        public UserStatus MyStatus { get; set; }

        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUser = new User();
            MyUserRole = new UserRole();
            MyStatus = new UserStatus();

        }

        public async Task<bool> UserAccessValidation(string pEmail, string pPassword)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyUser.Email = pEmail;
                MyUser.LoginPassword = pPassword;

                bool R = await MyUser.ValidateLogin();

                return R;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }

        }
        public async Task<bool> AddUser(string pEmail,
                                       string pName,
                                       string pPassword,
                                       string pIDNumber,
                                       string pPhoneNumber,
                                       string pAddress,
                                          int pUserRole=2,
                                       int pUserStatus = 2)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyUser.Email = pEmail;
                MyUser.LoginPassword = pPassword;
                MyUser.Name = pName;
                MyUser.PhoneNumber = pPhoneNumber;
                MyUser.Address = pAddress;
               
                MyUser.CardId = pIDNumber;

                  MyUser.UserRoleId= pUserRole;
                MyUser.UserStatusId = pUserStatus;

                bool R = await MyUser.AddUser();

                return R;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }



        }


    }
    }
