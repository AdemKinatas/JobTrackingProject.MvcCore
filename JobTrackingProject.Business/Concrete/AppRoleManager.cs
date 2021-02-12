using JobTrackingProject.Business.Abstract;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class AppRoleManager : IAppRoleService
    {
        IAppRoleDal _appRoleDal;

        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            _appRoleDal = appRoleDal;
        }

        public void Add(AppRole appRole)
        {
            _appRoleDal.Add(appRole);
        }

        public void Delete(AppRole appRole)
        {
            _appRoleDal.Delete(appRole);
        }

        public List<AppRole> GetAll(Expression<Func<AppRole, bool>> filter = null)
        {
            return _appRoleDal.GetAll(filter);
        }

        public AppRole GetByFilter(Expression<Func<AppRole, bool>> filter)
        {
            return _appRoleDal.GetByFilter(filter);
        }

        public void Update(AppRole appRole)
        {
            _appRoleDal.Update(appRole);
        }
    }
}
