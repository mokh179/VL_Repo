// <auto-generated />
using System;
using API.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.EF.Migrations
{
    [DbContext(typeof(API_Context))]
    partial class API_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.core.Models.Request", b =>
                {
                    b.Property<int>("requestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mobileNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("requestID");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
