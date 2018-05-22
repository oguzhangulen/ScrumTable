using Oguzhan.Scrum.Models.Context;
using Oguzhan.Scrum.Models.Models;
using Oguzhan.Scrum.WPF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oguzhan.Scrum.DAL.Implementations
{
    public class StoriesService
    {
        public bool Add(Stories inStories)
        {

            using (var context = new ScrumContext())
            {
                try
                {
                    if (inStories.ElementType == GeneralVariable.ElementType.NewStory.GetHashCode())
                    {
                        foreach (var item in context.Stories)
                        {
                            if (item.Position == inStories.Position)
                                context.Stories.Remove(item);
                        }
                    }
                        context.Stories.Add(inStories);
                    if (context.SaveChanges() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //logFile.CatchError("YS7TRyVYHUmRS10GOQYEw", ex);

                    return false;
                }
            }
        }

        public bool Delete(Stories inStories)
        {
            using (var context = new ScrumContext())
            {
                try
                {
                    context.Entry(inStories).State = EntityState.Deleted;
                    if (context.SaveChanges() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    //logFile.CatchError("adsfkjo2h394823n498273u4j", ex);
                  
                    return false;
                }
            }
        }
        public bool Update(Stories inStories)
        {
            using (var context = new ScrumContext())
            {
                try
                {
                    context.Entry(inStories).State = EntityState.Modified;
                    if (context.SaveChanges() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    //logFile.CatchError("asdf9o234nj92834n09234", ex);
                    
                    return false;
                }
            }
        }

        public List<Stories> GetAll()
        {

            using (var context = new ScrumContext())
            {
                try
                {
                    return context.Stories.OrderBy(s=>s.ProcessDate).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //logFile.CatchError("YS7TRyVYHUmRS10GOQYEw", ex);
                    return null;
                }
            }
        }
    }
}

