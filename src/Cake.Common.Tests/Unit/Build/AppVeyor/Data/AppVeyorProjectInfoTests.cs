﻿using Cake.Common.Tests.Fixtures.Build;
using Xunit;

namespace Cake.Common.Tests.Unit.Build.AppVeyor.Data
{
    public sealed class AppVeyorProjectInfoTests
    {
        public sealed class TheIdProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new AppVeyorInfoFixture().CreateProjectInfo();

                // When
                var result = info.Id;

                // Then
                Assert.Equal("85364", result);
            }
        }

        public sealed class TheNameProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new AppVeyorInfoFixture().CreateProjectInfo();

                // When
                var result = info.Name;

                // Then
                Assert.Equal("Cake", result);
            }
        }

        public sealed class TheSlugProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new AppVeyorInfoFixture().CreateProjectInfo();

                // When
                var result = info.Slug;

                // Then
                Assert.Equal("cake", result);
            }
        }
    }
}