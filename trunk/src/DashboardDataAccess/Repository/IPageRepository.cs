﻿namespace Dropthings.DataAccess.Repository
{
    using System;
    using System.Collections.Generic;

    public interface IPageRepository
    {
        #region Methods

        void Delete(int id);

        void Delete(Dropthings.DataAccess.Page page);

        Dropthings.DataAccess.Page GetPageById(int pageId);

        System.Collections.Generic.List<int> GetPageIdByUserGuid(Guid userGuid);

        Page GetFirstPageOfUser(Guid userGuid);

        string GetPageOwnerName(int pageId);

        System.Collections.Generic.List<Dropthings.DataAccess.Page> GetPagesOfUser(Guid userGuid);

        Dropthings.DataAccess.Page Insert(Action<Dropthings.DataAccess.Page> populate);

        void Update(Dropthings.DataAccess.Page page, Action<Dropthings.DataAccess.Page> detach, Action<Dropthings.DataAccess.Page> postAttachUpdate);
        void UpdateList(List<Page> pages, Action<Page> detach, Action<Page> postAttachUpdate);

        #endregion Methods
    }
}