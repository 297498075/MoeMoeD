﻿using MoeMoeD.Model.ViewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoeMoeD.IBLL
{
    public interface IFolderBLL : IBaseBLL<Folder>
    {
        //根据UserId查出此用户的所有Folder
        IList<Folder> GetByUserId(int userId);

        //根据FolderId查出此文件夹下的所有Folder
        IList<Folder> GetByFolderId(int folderId);

        //根据UserId查出此用户Root目录下的所有Folder
        IList<Folder> GetRootByUserId(int userId);

        //根据Id查出Folder
        Folder GetById(int id);

        bool UpdateNameById(int id, String name);

        Folder GetByNameAndUserId(string name, int userId);

        Folder GetByNameAndFolderId(string name, int folderId);

        new Folder Add(Folder folder);
    }
}
