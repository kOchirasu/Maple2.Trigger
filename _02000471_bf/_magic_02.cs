namespace Maple2.Trigger._02000471_bf {
    public static class _magic_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002020clear", value: 0);
                context.SetUserValue(triggerId: 2040317, key: "10002020clear", value: 0);
                context.SetUserValue(triggerId: 2040322, key: "10002020clear", value: 0);
                context.SetMesh(
                    arg1: new[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1728, 1729, 1730, 1731, 1732,
                        1733, 1734, 1735, 1736, 1737, 1738, 1739, 1740, 1741, 1742, 1743, 1744, 1745, 1746, 1747, 1748,
                        1749, 1750, 1751, 1752, 1753, 1754, 1755, 1756, 1757, 1758, 1759, 1760, 1761, 1762, 1763, 1764,
                        1765, 1766, 1767, 1768, 1769, 1770, 1771, 1772, 1773, 1774, 1775, 1776, 1777, 1778, 1779, 1780,
                        1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1795, 1796,
                        1797, 1798, 1799
                    }, arg2: false, arg3: 0, arg4: 200, arg5: 35f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002020}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: false);
                context.SetMesh(arg1: new[] {1102}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {1202}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.AddBuff(arg1: new[] {202}, arg2: 70002011, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {202})) {
                    context.State = new StateEvent_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002020clear", value: 1);
                context.SetUserValue(triggerId: 2040317, key: "10002020clear", value: 1);
                context.SetUserValue(triggerId: 2040322, key: "10002020clear", value: 1);
                context.SetAchievement(arg1: 712, arg2: "trigger", arg3: "Hauntedmansion");
                context.CreateMonster(arg1: new[] {1121, 1122}, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1728, 1729, 1730, 1731, 1732,
                        1733, 1734, 1735, 1736, 1737, 1738, 1739, 1740, 1741, 1742, 1743, 1744, 1745, 1746, 1747, 1748,
                        1749, 1750, 1751, 1752, 1753, 1754, 1755, 1756, 1757, 1758, 1759, 1760, 1761, 1762, 1763, 1764,
                        1765, 1766, 1767, 1768, 1769, 1770, 1771, 1772, 1773, 1774, 1775, 1776, 1777, 1778, 1779, 1780,
                        1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1795, 1796,
                        1797, 1798, 1799
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 35f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvent_02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_b : TriggerState {
            internal StateEvent_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1122, arg3: "$02000471_BF__MAGIC_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1121, arg3: "$02000471_BF__MAGIC_02__1$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEvent_02_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_02_c : TriggerState {
            internal StateEvent_02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716,
                        1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1728, 1729, 1730, 1731, 1732,
                        1733, 1734, 1735, 1736, 1737, 1738, 1739, 1740, 1741, 1742, 1743, 1744, 1745, 1746, 1747, 1748,
                        1749, 1750, 1751, 1752, 1753, 1754, 1755, 1756, 1757, 1758, 1759, 1760, 1761, 1762, 1763, 1764,
                        1765, 1766, 1767, 1768, 1769, 1770, 1771, 1772, 1773, 1774, 1775, 1776, 1777, 1778, 1779, 1780,
                        1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1795, 1796,
                        1797, 1798, 1799
                    }, arg2: false, arg3: 0, arg4: 200, arg5: 35f);
                context.DestroyMonster(arg1: new[] {1121, 1122});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}