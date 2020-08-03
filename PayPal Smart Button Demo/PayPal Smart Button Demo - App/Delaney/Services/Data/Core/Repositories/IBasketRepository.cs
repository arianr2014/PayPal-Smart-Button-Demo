/*********************************************************
       Code Generated By  .  .  .  .  Delaney's Script Bot
       WWW .  .  .  .  .  .  .  .  .  www.scriptbot.io
       Version.  .  .  .  .  .  .  .  10.0.0.14 
       Build  .  .  .  .  .  .  .  .  20191113 216
       Template Name.  .  .  .  .  .  Mosh (Repository EF)
       Template Version.  .  .  .  .  20191011 001
       Author .  .  .  .  .  .  .  .  Delaney

                          .___,
                       ___('v')___
                       `"-\._./-"'
                           ^ ^

*********************************************************/

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Delaney.Services.Data.Core.Repositories
{
    public partial interface IBasketRepository
    {
        bool IncludeDeleted { get; set; }
        Domain.Basket Get(int? id);

        Domain.Basket SingleOrDefault(Func<Domain.Basket, bool> predicate);

        bool Add(Domain.Basket entity);
        bool AddRange(IEnumerable<Domain.Basket> entities);

        IEnumerable<Domain.Basket> GetAll(); 
        IEnumerable<Domain.Basket> Find(Func<Domain.Basket, bool> predicate);

        /// <summary>
        /// Get the parent Basket for product and assign it the product.{parent class pascal}.
        /// </summary>
        void Get(Domain.Product product);

        /// <summary>
        /// Get the parent Basket for the collection of products and assign it the product.Backet.
        /// </summary>
        void Get(IEnumerable<Domain.Product> products);
        Domain.Basket GetWithParents(int id);
        Domain.Basket GetWithChildren(int id);
        Domain.Basket GetWithFamily(int id);
        DataStoreResult Remove(int Id,
                               out string errorMessage);

        DataStoreResult Remove(Domain.Basket entity,
                               out string errorMessage);

        DataStoreResult RemoveRange(IEnumerable<Domain.Basket> entities,
                                    out string errorMessage);
    }
}