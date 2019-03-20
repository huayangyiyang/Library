using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 用户表业务逻辑的接口
    /// : IBaseBLL<User> 代表 IUserBLL 中 拥有 IBaseBLL 中的 所有方法
    ///                  代表 IUserBLL 已经指定 泛型接口中 T 的数据类型 为 User
    /// </summary>
    public interface IUserBLL : IBaseBLL<LAdmin>
    {

    }
}
