using Library_DataAccessLayer.Repostories.Abstracts;
using Library_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccessLayer.Repostories.Concretes;

public class TCardRepository : GenericRepository<TCard> , ITCardRepository
{
}
