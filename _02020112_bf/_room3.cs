using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _room3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "EliteDead", value: 1)) {
                    context.State = new State종료2(context);
                    return;
                }

                if (context.UserValue(key: "Extinction", value: 1)
                    && context.UserValue(key: "Extinction_1_check", value: 1)
                    && context.UserValue(key: "Extinction_2_check", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__ROOM3__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.UserValue(key: "EliteDead", value: 1)) {
                    context.State = new State종료2(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State격리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State격리 : TriggerState {
            internal State격리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02020112, arg2: 6, arg3: 932, arg4: 1);
                context.SetTimer(arg1: "1", arg2: 20, arg4: true, arg5: -40);
                context.SetMesh(
                    arg1: new int[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(
                    arg1: new int[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.CreateMonster(arg1: new int[] {181}, arg2: false);
                context.CreateMonster(arg1: new int[] {182}, arg2: false);
                context.CreateMonster(arg1: new int[] {183}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__ROOM3__1$", arg3: new int[] {5000}, arg4: "932");
                context.AddBuff(arg1: new int[] {941}, arg2: 70002106, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "EliteDead", value: 1)) {
                    context.State = new State종료2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {181, 182, 183})) {
                    context.State = new State구출(context);
                    return;
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {941}, arg2: 70002107, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "EliteDead", value: 1)) {
                    context.State = new State종료2(context);
                    return;
                }

                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출 : TriggerState {
            internal State구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020112, arg2: 5, arg3: 941);
            }

            public override void Execute() {
                if (context.UserValue(key: "EliteDead", value: 1)) {
                    context.State = new State종료2(context);
                    return;
                }

                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {181, 182, 183});
                context.MoveUser(arg1: 02020112, arg2: 5, arg3: 941);
                context.SetMesh(
                    arg1: new int[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727
                    }, arg2: false, arg3: 0, arg4: 30, arg5: 3f);
                context.SetMesh(
                    arg1: new int[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827
                    }, arg2: true, arg3: 0, arg4: 30, arg5: 3f);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료2 : TriggerState {
            internal State종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}