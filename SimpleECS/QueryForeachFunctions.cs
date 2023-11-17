namespace SimpleECS;

public partial class Query
{
    public delegate void C10Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void C11Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9,
        ref C10 c10, ref C11 c11);

    public delegate void C12Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9,
        ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void C1Query<C1>(ref C1 c1);

    public delegate void C2Query<C1, C2>(ref C1 c1, ref C2 c2);

    public delegate void C3Query<C1, C2, C3>(ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void C4Query<C1, C2, C3, C4>(ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void C5Query<C1, C2, C3, C4, C5>(ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5);

    public delegate void C6Query<C1, C2, C3, C4, C5, C6>(ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6);

    public delegate void C7Query<C1, C2, C3, C4, C5, C6, C7>(ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void C8Query<C1, C2, C3, C4, C5, C6, C7, C8>(ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void C9Query<C1, C2, C3, C4, C5, C6, C7, C8, C9>(ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void Ec10Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10);

    public delegate void Ec11Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void Ec12Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void Ec1Query<C1>(Entity entity, ref C1 c1);

    public delegate void Ec2Query<C1, C2>(Entity entity, ref C1 c1, ref C2 c2);

    public delegate void Ec3Query<C1, C2, C3>(Entity entity, ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void Ec4Query<C1, C2, C3, C4>(Entity entity, ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4);

    public delegate void Ec5Query<C1, C2, C3, C4, C5>(Entity entity, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void Ec6Query<C1, C2, C3, C4, C5, C6>(Entity entity, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void Ec7Query<C1, C2, C3, C4, C5, C6, C7>(Entity entity, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void Ec8Query<C1, C2, C3, C4, C5, C6, C7, C8>(Entity entity, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void Ec9Query<C1, C2, C3, C4, C5, C6, C7, C8, C9>(Entity entity, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void W1C10Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10);

    public delegate void W1C11Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(in W1 w1,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W1C12Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(in W1 w1,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W1C1Query<W1, C1>(in W1 w1, ref C1 c1);

    public delegate void W1C2Query<W1, C1, C2>(in W1 w1, ref C1 c1, ref C2 c2);

    public delegate void W1C3Query<W1, C1, C2, C3>(in W1 w1, ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void W1C4Query<W1, C1, C2, C3, C4>(in W1 w1, ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4);

    public delegate void W1C5Query<W1, C1, C2, C3, C4, C5>(in W1 w1, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W1C6Query<W1, C1, C2, C3, C4, C5, C6>(in W1 w1, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W1C7Query<W1, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void W1C8Query<W1, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void W1C9Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void W1Ec10Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W1Ec11Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(in W1 w1,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W1Ec12Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1 w1, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W1Ec1Query<W1, C1>(in W1 w1, Entity entity, ref C1 c1);

    public delegate void W1Ec2Query<W1, C1, C2>(in W1 w1, Entity entity, ref C1 c1, ref C2 c2);

    public delegate void W1Ec3Query<W1, C1, C2, C3>(in W1 w1, Entity entity, ref C1 c1, ref C2 c2,
        ref C3 c3);

    public delegate void W1Ec4Query<W1, C1, C2, C3, C4>(in W1 w1, Entity entity, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W1Ec5Query<W1, C1, C2, C3, C4, C5>(in W1 w1, Entity entity, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W1Ec6Query<W1, C1, C2, C3, C4, C5, C6>(in W1 w1, Entity entity, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W1Ec7Query<W1, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void W1Ec8Query<W1, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void W1Ec9Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9);

    public delegate void W2C10Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        in W2 w2, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W2C11Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(in W1 w1,
        in W2 w2, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W2C12Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1 w1, in W2 w2, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W2C1Query<W1, W2, C1>(in W1 w1, in W2 w2, ref C1 c1);

    public delegate void W2C2Query<W1, W2, C1, C2>(in W1 w1, in W2 w2, ref C1 c1, ref C2 c2);

    public delegate void W2C3Query<W1, W2, C1, C2, C3>(in W1 w1, in W2 w2, ref C1 c1, ref C2 c2,
        ref C3 c3);

    public delegate void W2C4Query<W1, W2, C1, C2, C3, C4>(in W1 w1, in W2 w2, ref C1 c1, ref C2 c2,
        ref C3 c3, ref C4 c4);

    public delegate void W2C5Query<W1, W2, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W2C6Query<W1, W2, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2, ref C1 c1,
        ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W2C7Query<W1, W2, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void W2C8Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, in W2 w2,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void W2C9Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1, in W2 w2,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8,
        ref C9 c9);

    public delegate void W2Ec10Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        in W2 w2, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W2Ec11Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(in W1 w1,
        in W2 w2, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W2Ec12Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1 w1, in W2 w2, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W2Ec1Query<W1, W2, C1>(in W1 w1, in W2 w2, Entity entity, ref C1 c1);

    public delegate void W2Ec2Query<W1, W2, C1, C2>(in W1 w1, in W2 w2, Entity entity, ref C1 c1,
        ref C2 c2);

    public delegate void W2Ec3Query<W1, W2, C1, C2, C3>(in W1 w1, in W2 w2, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void W2Ec4Query<W1, W2, C1, C2, C3, C4>(in W1 w1, in W2 w2, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W2Ec5Query<W1, W2, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2, Entity entity,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W2Ec6Query<W1, W2, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W2Ec7Query<W1, W2, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void W2Ec8Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, in W2 w2,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8);

    public delegate void W2Ec9Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1, in W2 w2,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8, ref C9 c9);

    public delegate void W3C10Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        in W2 w2, in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W3C11Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1 w1, in W2 w2, in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W3C12Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1 w1, in W2 w2, in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W3C1Query<W1, W2, W3, C1>(in W1 w1, in W2 w2, in W3 w3, ref C1 c1);

    public delegate void W3C2Query<W1, W2, W3, C1, C2>(in W1 w1, in W2 w2, in W3 w3, ref C1 c1,
        ref C2 c2);

    public delegate void W3C3Query<W1, W2, W3, C1, C2, C3>(in W1 w1, in W2 w2, in W3 w3, ref C1 c1,
        ref C2 c2, ref C3 c3);

    public delegate void W3C4Query<W1, W2, W3, C1, C2, C3, C4>(in W1 w1, in W2 w2, in W3 w3,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W3C5Query<W1, W2, W3, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2, in W3 w3,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W3C6Query<W1, W2, W3, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2, in W3 w3,
        ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W3C7Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7);

    public delegate void W3C8Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, in W2 w2,
        in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7,
        ref C8 c8);

    public delegate void W3C9Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1,
        in W2 w2, in W3 w3, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void W3Ec10Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(in W1 w1,
        in W2 w2, in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W3Ec11Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1 w1, in W2 w2, in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void W3Ec12Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1 w1, in W2 w2, in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11,
        ref C12 c12);

    public delegate void W3Ec1Query<W1, W2, W3, C1>(in W1 w1, in W2 w2, in W3 w3, Entity entity,
        ref C1 c1);

    public delegate void W3Ec2Query<W1, W2, W3, C1, C2>(in W1 w1, in W2 w2, in W3 w3, Entity entity,
        ref C1 c1, ref C2 c2);

    public delegate void W3Ec3Query<W1, W2, W3, C1, C2, C3>(in W1 w1, in W2 w2, in W3 w3,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void W3Ec4Query<W1, W2, W3, C1, C2, C3, C4>(in W1 w1, in W2 w2, in W3 w3,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W3Ec5Query<W1, W2, W3, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2, in W3 w3,
        Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W3Ec6Query<W1, W2, W3, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2,
        in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W3Ec7Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7);

    public delegate void W3Ec8Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1, in W2 w2,
        in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7, ref C8 c8);

    public delegate void W3Ec9Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1,
        in W2 w2, in W3 w3, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void W4C10Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W1 w1, in W2 w2, in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W4C11Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1 w1, in W2 w2, in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void
        W4C12Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(in W1 w1,
            in W2 w2, in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
            ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11, ref C12 c12);

    public delegate void W4C1Query<W1, W2, W3, W4, C1>(in W1 w1, in W2 w2, in W3 w3, in W4 w4,
        ref C1 c1);

    public delegate void W4C2Query<W1, W2, W3, W4, C1, C2>(in W1 w1, in W2 w2, in W3 w3, in W4 w4,
        ref C1 c1, ref C2 c2);

    public delegate void W4C3Query<W1, W2, W3, W4, C1, C2, C3>(in W1 w1, in W2 w2, in W3 w3,
        in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void W4C4Query<W1, W2, W3, W4, C1, C2, C3, C4>(in W1 w1, in W2 w2, in W3 w3,
        in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W4C5Query<W1, W2, W3, W4, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2, in W3 w3,
        in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W4C6Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2,
        in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6);

    public delegate void W4C7Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5, ref C6 c6,
        ref C7 c7);

    public delegate void W4C8Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1,
        in W2 w2, in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void W4C9Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1,
        in W2 w2, in W3 w3, in W4 w4, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    public delegate void W4Ec10Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W1 w1, in W2 w2, in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10);

    public delegate void W4Ec11Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1 w1, in W2 w2, in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3,
        ref C4 c4, ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11);

    public delegate void
        W4Ec12Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(in W1 w1,
            in W2 w2, in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
            ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9, ref C10 c10, ref C11 c11,
            ref C12 c12);

    public delegate void W4Ec1Query<W1, W2, W3, W4, C1>(in W1 w1, in W2 w2, in W3 w3, in W4 w4,
        Entity entity, ref C1 c1);

    public delegate void W4Ec2Query<W1, W2, W3, W4, C1, C2>(in W1 w1, in W2 w2, in W3 w3, in W4 w4,
        Entity entity, ref C1 c1, ref C2 c2);

    public delegate void W4Ec3Query<W1, W2, W3, W4, C1, C2, C3>(in W1 w1, in W2 w2, in W3 w3,
        in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3);

    public delegate void W4Ec4Query<W1, W2, W3, W4, C1, C2, C3, C4>(in W1 w1, in W2 w2, in W3 w3,
        in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4);

    public delegate void W4Ec5Query<W1, W2, W3, W4, C1, C2, C3, C4, C5>(in W1 w1, in W2 w2,
        in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5);

    public delegate void W4Ec6Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6>(in W1 w1, in W2 w2,
        in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6);

    public delegate void W4Ec7Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7>(in W1 w1, in W2 w2,
        in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4, ref C5 c5,
        ref C6 c6, ref C7 c7);

    public delegate void W4Ec8Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8>(in W1 w1,
        in W2 w2, in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8);

    public delegate void W4Ec9Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9>(in W1 w1,
        in W2 w2, in W3 w3, in W4 w4, Entity entity, ref C1 c1, ref C2 c2, ref C3 c3, ref C4 c4,
        ref C5 c5, ref C6 c6, ref C7 c7, ref C8 c8, ref C9 c9);

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1>(in C1Query<C1> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2>(in C2Query<C1, C2> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3>(in C3Query<C1, C2, C3> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4>(in C4Query<C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5>(in C5Query<C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6>(in C6Query<C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7>(in C7Query<C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8>(
        in C8Query<C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in C9Query<C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in C10Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in C11Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in C12Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e], ref c6[e],
                            ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1>(in Ec1Query<C1> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2>(in Ec2Query<C1, C2> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3>(in Ec3Query<C1, C2, C3> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4>(in Ec4Query<C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5>(in Ec5Query<C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6>(in Ec6Query<C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void
        Foreach<C1, C2, C3, C4, C5, C6, C7>(in Ec7Query<C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8>(
        in Ec8Query<C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in Ec9Query<C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in Ec10Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in Ec11Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in Ec12Query<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e],
                            ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1>(in W1C1Query<W1, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1>(in W2C1Query<W1, W2, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1>(in W3C1Query<W1, W2, W3, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1>(in W4C1Query<W1, W2, W3, W4, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2>(in W1C2Query<W1, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2>(in W2C2Query<W1, W2, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2>(in W3C2Query<W1, W2, W3, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2>(in W4C2Query<W1, W2, W3, W4, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3>(in W1C3Query<W1, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3>(in W2C3Query<W1, W2, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3>(in W3C3Query<W1, W2, W3, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void
        Foreach<W1, W2, W3, W4, C1, C2, C3>(in W4C3Query<W1, W2, W3, W4, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4>(in W1C4Query<W1, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4>(in W2C4Query<W1, W2, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void
        Foreach<W1, W2, W3, C1, C2, C3, C4>(in W3C4Query<W1, W2, W3, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4>(
        in W4C4Query<W1, W2, W3, W4, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5>(in W1C5Query<W1, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void
        Foreach<W1, W2, C1, C2, C3, C4, C5>(in W2C5Query<W1, W2, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5>(
        in W3C5Query<W1, W2, W3, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5>(
        in W4C5Query<W1, W2, W3, W4, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void
        Foreach<W1, C1, C2, C3, C4, C5, C6>(in W1C6Query<W1, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6>(
        in W2C6Query<W1, W2, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6>(
        in W3C6Query<W1, W2, W3, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6>(
        in W4C6Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7>(
        in W1C7Query<W1, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7>(
        in W2C7Query<W1, W2, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7>(
        in W3C7Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7>(
        in W4C7Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W1C8Query<W1, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W2C8Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W3C8Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W4C8Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W1C9Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W2C9Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W3C9Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W4C9Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W1C10Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W2C10Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W3C10Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W4C10Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1C11Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W2C11Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W3C11Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e],
                            ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W4C11Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1C12Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e],
                            ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W2C12Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, ref c1[e], ref c2[e], ref c3[e], ref c4[e], ref c5[e],
                            ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e], ref c11[e],
                            ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W3C12Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e],
                            ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W4C12Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1>(in W1Ec1Query<W1, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1>(in W2Ec1Query<W1, W2, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1>(in W3Ec1Query<W1, W2, W3, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1>(in W4Ec1Query<W1, W2, W3, W4, C1> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2>(in W1Ec2Query<W1, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2>(in W2Ec2Query<W1, W2, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2>(in W3Ec2Query<W1, W2, W3, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2>(in W4Ec2Query<W1, W2, W3, W4, C1, C2> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3>(in W1Ec3Query<W1, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3>(in W2Ec3Query<W1, W2, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3>(in W3Ec3Query<W1, W2, W3, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3>(
        in W4Ec3Query<W1, W2, W3, W4, C1, C2, C3> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4>(in W1Ec4Query<W1, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4>(in W2Ec4Query<W1, W2, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4>(
        in W3Ec4Query<W1, W2, W3, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4>(
        in W4Ec4Query<W1, W2, W3, W4, C1, C2, C3, C4> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5>(in W1Ec5Query<W1, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5>(
        in W2Ec5Query<W1, W2, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5>(
        in W3Ec5Query<W1, W2, W3, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5>(
        in W4Ec5Query<W1, W2, W3, W4, C1, C2, C3, C4, C5> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6>(
        in W1Ec6Query<W1, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6>(
        in W2Ec6Query<W1, W2, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6>(
        in W3Ec6Query<W1, W2, W3, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6>(
        in W4Ec6Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7>(
        in W1Ec7Query<W1, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7>(
        in W2Ec7Query<W1, W2, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7>(
        in W3Ec7Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7>(
        in W4Ec7Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W1Ec8Query<W1, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W2Ec8Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W3Ec8Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8>(
        in W4Ec8Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W1Ec9Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W2Ec9Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W3Ec9Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9>(
        in W4Ec9Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e],
                            ref c9[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W1Ec10Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W2Ec10Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W3Ec10Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(
        in W4Ec10Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e],
                            ref c9[e], ref c10[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W1Ec11Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e],
                            ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W2Ec11Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W3Ec11Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(
        in W4Ec11Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e],
                            ref c9[e], ref c10[e], ref c11[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W1Ec12Query<W1, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, entities[e], ref c1[e], ref c2[e], ref c3[e], ref c4[e],
                            ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e], ref c10[e],
                            ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W2Ec12Query<W1, W2, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W3Ec12Query<W1, W2, W3, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, entities[e], ref c1[e], ref c2[e], ref c3[e],
                            ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e], ref c9[e],
                            ref c10[e], ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }

    /// <summary>
    ///     performs the action on all entities that match the query.
    ///     query must be in the form of '(in world_data', entity, ref components)'.
    ///     query can add up to 4 world data and 12 components
    /// </summary>
    public void Foreach<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(
        in W4Ec12Query<W1, W2, W3, W4, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12> action) {
        if (Update(out var world_info)) {
            ref var w1 = ref _world.GetData<W1>();
            ref var w2 = ref _world.GetData<W2>();
            ref var w3 = ref _world.GetData<W3>();
            ref var w4 = ref _world.GetData<W4>();

            world_info.structureEvents.EnqueueEvents++;
            for (int archetype_index = 0; archetype_index < _archetypeCount; ++archetype_index) {
                var archetype = world_info.archetypes[_matchingArchetypes[archetype_index]].data;
                int count = archetype.entity_Count;
                var entities = archetype.entities;
                if (count > 0 && archetype.TryGetArray(out C1[] c1) &&
                    archetype.TryGetArray(out C2[] c2) && archetype.TryGetArray(out C3[] c3) &&
                    archetype.TryGetArray(out C4[] c4) && archetype.TryGetArray(out C5[] c5) &&
                    archetype.TryGetArray(out C6[] c6) && archetype.TryGetArray(out C7[] c7) &&
                    archetype.TryGetArray(out C8[] c8) && archetype.TryGetArray(out C9[] c9) &&
                    archetype.TryGetArray(out C10[] c10) && archetype.TryGetArray(out C11[] c11) &&
                    archetype.TryGetArray(out C12[] c12))
                    for (int e = 0; e < count; ++e)
                        action(in w1, in w2, in w3, in w4, entities[e], ref c1[e], ref c2[e],
                            ref c3[e], ref c4[e], ref c5[e], ref c6[e], ref c7[e], ref c8[e],
                            ref c9[e], ref c10[e], ref c11[e], ref c12[e]);
            }
            world_info.structureEvents.EnqueueEvents--;
        }
    }
}