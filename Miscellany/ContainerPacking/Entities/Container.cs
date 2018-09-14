﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CromulentBisgetti.ContainerPacking;
using CromulentBisgetti.ContainerPacking.Algorithms;
using CromulentBisgetti.ContainerPacking.Entities;

namespace Miscellany.ContainerPacking.Entities
{
    /// <summary>
    /// The container to pack items into.
    /// </summary>
    public class Container
    {
        CromulentBisgetti.ContainerPacking.Entities.Container c;

        #region Private Variables

        private double volume;

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Container class.
        /// </summary>
        /// <param name="id">The container ID.</param>
        /// <param name="length">The container length.</param>
        /// <param name="width">The container width.</param>
        /// <param name="height">The container height.</param>
        public Container(int id, double length, double width, double height)
        {
            decimal dLength = Miscellany.Math.Functions.ToDecimal(length);
            decimal dWidth = Miscellany.Math.Functions.ToDecimal(width);
            decimal dHeight = Miscellany.Math.Functions.ToDecimal(height);
            c = new CromulentBisgetti.ContainerPacking.Entities.Container(id, dLength, dWidth, dHeight);
            this.ID = id;
            this.Length = Miscellany.Math.Functions.ToDouble(c.Length);
            this.Width = Miscellany.Math.Functions.ToDouble(c.Width);
            this.Height = Miscellany.Math.Functions.ToDouble(c.Height);
            this.volume = length * width * height;
        }

        #endregion Constructors

        #region Public Properties
        /// <summary>
        /// Gets or sets the container ID.
        /// </summary>
        /// <value>
        /// The container ID.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the container length.
        /// </summary>
        /// <value>
        /// The container length.
        /// </value>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets the container width.
        /// </summary>
        /// <value>
        /// The container width.
        /// </value>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the container height.
        /// </summary>
        /// <value>
        /// The container height.
        /// </value>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the volume of the container.
        /// </summary>
        /// <value>
        /// The volume of the container.
        /// </value>
        public double Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                this.volume = value;
            }
        }

        #endregion Public Properties
    }
}