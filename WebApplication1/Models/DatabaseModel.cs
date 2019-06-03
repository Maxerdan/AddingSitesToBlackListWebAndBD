using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace WebApplication1.Models
{
    namespace DataAccessPostgreSqlProvider
    {
        // >dotnet ef migration add testMigration in AspNet5MultipleProject
        public class AddSitesDBContext : DbContext
        {
            public AddSitesDBContext()
            {

                Database.EnsureCreated();
            }

            public AddSitesDBContext(DbContextOptions<AddSitesDBContext> options) : base(options)
            {
            }

            public DbSet<DbSites> SpaceShips { get; set; }
            public DbSet<DbListOfSites> Flights { get; set; }
            public static string ConnectionString { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(AddSitesDBContext.ConnectionString);

                base.OnConfiguring(optionsBuilder);
            }
        }

        public class DbSites
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            /// <summary>
            /// Список сайтов
            /// </summary>
            public virtual Collection<DbListOfSites> SitesList { get; set; }
        }
        

        public class DbListOfSites
        {

            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public int SpaceShipId { get; set; }
            [ForeignKey("SpaceShipId")]
            public virtual DbSites SpaceShip { get; set; }
            /// <summary>
            /// Адрес сайта
            /// </summary>
            public string Adress { get; set; }

            /// <summary>
            /// Адрес публикации
            /// </summary>
            public string AdressPubl { get; set; }

            /// <summary>
            /// Комментарий
            /// </summary>
            public string Reason { get; set; }

            /// <summary>
            /// Список нарушений
            /// </summary>
            public List<string> Violations = new List<string>()
        {
            "Экстремизм", "Угрозы к свержению власти", "Нарушение авторских прав", "Нарушение тайны частной жизни", "Раскрытие гостайны"
        };

            /// <summary>
            /// Причина
            /// </summary>
            public string Violation { get; set; }

            /// <summary>
            /// Дата отправки 
            /// </summary>
            public DateTime SendingDay { get; set; }

            /// <summary>
            /// Возможная дата нарушения
            /// </summary>
            public DateTime PublishDate { get; set; }

            /// <summary>
            /// Скриншот прилагаемый
            /// </summary>
            public byte[] Screenshot { get; set; }

            /// <summary>
            /// Статус строкой
            /// </summary>
            public string Stat { get; set; }

            /// <summary>
            /// Дата блокировки
            /// </summary>
            public DateTime BlockDate { get; set; }

            public override string ToString()
            {
                return $"Адрес: {Adress}, Адрес публикации: {AdressPubl}, Причина: {Violation}, Комментарий: {Reason}, СТАТУС: {Stat}, Дата блокировки: {BlockDate}";
            }
        }
    }
}