namespace Maple2.Trigger._02020112_bf {
    public static class _room1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "Extinction_1_check", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EliteDead") == 1) {
                    return new StateEnd2(context);
                }

                if (context.GetUserValue(key: "Extinction") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020112_BF__ROOM1__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EliteDead") == 1) {
                    return new StateEnd2(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new State격리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State격리 : TriggerState {
            internal State격리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(mapId: 02020112, portalId: 6, triggerId: 932, count: 1);
                context.SetTimer(timerId: "1", seconds: 20, display: true, vOffset: -40);
                context.SetMesh(triggerIds: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727}, visible: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.CreateMonster(spawnIds: new []{181, 182, 183}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02020112_BF__ROOM1__1$", duration: 5000, boxId: 932);
                context.AddBuff(boxIds: new []{941}, skillId: 70002106, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EliteDead") == 1) {
                    return new StateEnd2(context);
                }

                if (context.MonsterDead(spawnIds: new []{181, 182, 183})) {
                    return new State구출(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{941}, skillId: 70002107, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EliteDead") == 1) {
                    return new StateEnd2(context);
                }

                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State구출 : TriggerState {
            internal State구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020112, portalId: 5, boxId: 941);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "EliteDead") == 1) {
                    return new StateEnd2(context);
                }

                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "Extinction_1_check", value: 1);
                context.DestroyMonster(spawnIds: new []{181, 182, 183});
                context.MoveUser(mapId: 02020112, portalId: 5, boxId: 941);
                context.SetMesh(triggerIds: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727}, visible: false, arg3: 0, arg4: 30, arg5: 3f);
                context.SetMesh(triggerIds: new []{1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827}, visible: true, arg3: 0, arg4: 30, arg5: 3f);
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
