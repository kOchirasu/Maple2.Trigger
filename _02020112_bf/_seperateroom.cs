namespace Maple2.Trigger._02020112_bf {
    public static class _seperateroom {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 99990013, key: "Extinction", value: 0);
                context.SetUserValue(triggerId: 99990014, key: "Extinction", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "Extinction", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Start") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 191) <= 0.70f) {
                    context.State = new State격리조치_1_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State격리조치_1_준비 : TriggerState {
            internal State격리조치_1_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990013, key: "Extinction", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 191) <= 0.45f) {
                    context.State = new State격리조치_2_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State격리조치_2_준비 : TriggerState {
            internal State격리조치_2_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "Extinction", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 191) <= 0.20f) {
                    context.State = new State격리조치_2_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State격리조치_3_준비 : TriggerState {
            internal State격리조치_3_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990015, key: "Extinction", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {181, 182, 183});
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetMesh(
                    arg1: new[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(
                    arg1: new[] {
                        1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816,
                        1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}