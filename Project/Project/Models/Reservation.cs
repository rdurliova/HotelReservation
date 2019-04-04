namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        private int id;
        private int? idClient;
        private int? idRoom;
        private DateTime? startDate;
        private DateTime? finishDate;
        private decimal? payment;
        private string paymentType;

        public Reservation()
        {

        }
        public Reservation(int idClient, int idRoom, DateTime startDate, DateTime finishDate, decimal payment, string paymentType)
        {
            this.IdClient = idClient;
            this.IdRoom = idRoom;
            this.DataStart = startDate;
            this.DataFinish = finishDate;
            this.Payment = payment;
            this.PaymentType = paymentType;
        }
   
        public int Id {
            get { return this.id; }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Id ������ �� ���� ��-������ �� 0");
                }
            }
        }

        public int? IdClient
        { 
        get {return this.IdClient;}
            set
            {
                if (value > 0)
                {
                    this.idClient = value;
                }
                else
                {
                    throw new ArgumentException("Client id ������ �� ���� ��-������ �� 0!");
                }

            }
                }

        public int? IdRoom
        {
            get { return this.idRoom; } 
            set
            {
                if (value > 0)
                {
                    this.idRoom = value;
                }
                else

              {
                    throw new ArgumentException("Room id ������ �� ���� ��-������ 0!");
                }

            }
                }

        [Column(TypeName = "date")]
        public DateTime? DataStart
        {
            get { return this.DataStart; }
            set
            {
                if (value<DateTime.Now)
                {
                    throw new ArgumentException("��������� ���� �� ���� �� ���� ��-���� �� ����");
                }
                else
                {
                    this.startDate = value;
                }
            }
        }

        [Column(TypeName = "date")]
        public DateTime? DataFinish
        {
            get { return this.finishDate; }
            set
            {
                if (value < this.DataStart)
                {
                    throw new ArgumentException("�������� ���� �� ���� �� ���� ��-���� �� ���������");
                }
                else
                {
                    this.finishDate = value;
                }

            }
        }

        public decimal? Payment
        {
            get { return this.payment; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("��������� �� ���� �� ���� ��-����� �� 0!");
                }
                this.payment = value;
            }

        }

        [StringLength(20)]
        public string PaymentType
        {
            get { return this.paymentType; }
            set
            {
                if (value!=string.Empty)
                {
                    this.paymentType = value;
                }
                else
                {
                    throw new AccessViolationException("PaymentType �� ���� �� ���� ������");
                }
            }
        }

        public virtual Client Client { get; set; }

        public virtual Room Room { get; set; }
    }
}
