// <auto-generated />
using DEMO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DEMO.Migrations
{
    [DbContext(typeof(DOMO_Context))]
    [Migration("20211203162733_AddHero_Password")]
    partial class AddHero_Password
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DEMO.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Heros");
                });

            modelBuilder.Entity("DEMO.Models.HeroAcheivement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcheivementDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HeorId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeorId");

                    b.ToTable("HeroAcheivements");
                });

            modelBuilder.Entity("DEMO.Models.HeroAcheivement", b =>
                {
                    b.HasOne("DEMO.Models.Hero", "Hero")
                        .WithMany("Acheivements")
                        .HasForeignKey("HeorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");
                });

            modelBuilder.Entity("DEMO.Models.Hero", b =>
                {
                    b.Navigation("Acheivements");
                });
#pragma warning restore 612, 618
        }
    }
}
