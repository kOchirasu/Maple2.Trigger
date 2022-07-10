namespace Maple2.Trigger._02020112_bf {
    public static class _seperateroom {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 99990013, key: "Extinction", value: 0);
                context.SetUserValue(triggerId: 99990014, key: "Extinction", value: 0);
                context.SetUserValue(triggerId: 99990015, key: "Extinction", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 191) <= 0.70f) {
                    return new State격리조치_1_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리조치_1_Prepare : TriggerState {
            internal State격리조치_1_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990013, key: "Extinction", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 191) <= 0.45f) {
                    return new State격리조치_2_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리조치_2_Prepare : TriggerState {
            internal State격리조치_2_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "Extinction", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 191) <= 0.20f) {
                    return new State격리조치_2_Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리조치_3_Prepare : TriggerState {
            internal State격리조치_3_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990015, key: "Extinction", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Start") == 2) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{181, 182, 183});
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.ResetTimer(timerId: "3");
                context.SetMesh(triggerIds: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827}, visible: true, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
