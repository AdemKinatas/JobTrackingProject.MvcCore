using JobTrackingProject.Business.Abstract;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser appUser)
        {
            _appUserDal.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _appUserDal.Delete(appUser);
        }

        public List<AppUser> GetAll(Expression<Func<AppUser, bool>> filter = null)
        {
            return _appUserDal.GetAll(filter);
        }

        public AppUser GetByFilter(Expression<Func<AppUser, bool>> filter)
        {
            return _appUserDal.GetByFilter(filter);
        }

        public void Update(AppUser appUser)
        {
            _appUserDal.Update(appUser);
        }
    }
}
