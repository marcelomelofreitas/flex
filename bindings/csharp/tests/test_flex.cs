// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See the LICENSE.txt file in the project root
// for the license information.

using System;
using Xamarin.Flex;

public partial class Test
{
    void test_flex_shorthand0()
    {
        var i = new Item();
        i.Flex();

        assert(i.Grow == 0);    // default
        assert(i.Shrink == 1);  // default
        assert(i.Basis == 0);   // default

        i.Dispose();
    }

    void test_flex_shorthand1()
    {
        var i = new Item();
        i.Flex(3);

        assert(i.Grow == 3);
        assert(i.Shrink == 1);  // default
        assert(i.Basis == 0);   // default

        i.Dispose();
    }

    void test_flex_shorthand2()
    {
        var i = new Item();
        i.Flex(3, 2);

        assert(i.Grow == 3);
        assert(i.Shrink == 2);
        assert(i.Basis == 0);   // default

        i.Dispose();
    }

    void test_flex_shorthand3()
    {
        var i = new Item();
        i.Flex(3, 2, 100);

        assert(i.Grow == 3);
        assert(i.Shrink == 2);
        assert(i.Basis == 100);

        i.Dispose();
    }

    void test_flex_shorthand4()
    {
        var i = new Item();
        i.Flex(basis:100, shrink:2);

        assert(i.Grow == 0);    // default
        assert(i.Shrink == 2);
        assert(i.Basis == 100);

        i.Dispose();
    }

    void test_flex_shorthand5()
    {
        var i = new Item();
        i.Flex(basis:-1, shrink:2);

        assert(i.Grow == 0);    // default
        assert(i.Shrink == 2);
        assert(i.Basis == 0);   // default

        i.Dispose();
    }

    void test_flex_shorthand6()
    {
        var i = new Item();
        i.Flex(grow:-1, shrink:-1);

        assert(i.Grow == 0);    // default
        assert(i.Shrink == 1);  // default
        assert(i.Basis == 0);   // default

        i.Dispose();
    }

    void test_flex_shorthand7()
    {
        var i = new Item();
        i.Flex(basis:100, shrink:2, grow:3);

        assert(i.Grow == 3);
        assert(i.Shrink == 2);
        assert(i.Basis == 100);

        i.Dispose();
    }
}
