﻿using System;
using Castle.Windsor;
using MethodInvocationLogger.Castle.Tests.Helpers;
using MethodInvocationLogger.Tests;
using NUnit.Framework;

namespace MethodInvocationLogger.Castle.Tests
{
	[TestFixture]
	public class CastleInvocationRawDataFillTests : InvocationRawDataFillTests
	{
		protected override Func<ILogger<object>, MethodInvocationLogger.Tests.Helpers.IContainer> PrepareLoggerAndGetContainer
		{
			get
			{
				return logger =>
				{
					WindsorContainer container = new WindsorContainer();
					logger.BindToWindsor(container.Kernel);
					return new CastleContainer(container);
				};
			}
		}
	}
}