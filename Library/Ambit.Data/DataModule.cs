//-----------------------------------------------------------------------
// <copyright file="DataModule.cs" company="Dexoc Solutions">
//     Copyright Dexoc Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Ambit.Data
{
    using Autofac;
    using Ambit.Data.Contract;

    /// <summary>
    /// Contract Class for DataModule.
    /// </summary>
    public class DataModule : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {            
            builder.RegisterType<V1.CustomerLoginDao>().As<AbstractCustomerLoginDao>().InstancePerDependency();
            base.Load(builder);
        }
    }
}
