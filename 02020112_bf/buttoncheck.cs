namespace Maple2.Trigger._02020112_bf {
    public static class _buttoncheck {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9901, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9902, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9903, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9904, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 0);
                context.AddBuff(arg1: new[] {916}, arg2: 70002104, arg3: 1, arg5: false);
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetEffect(arg1: new[] {8002, 8003, 8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GravityRoom") == 1) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {916}, arg2: 70002104, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {911})) {
                    return new State감지_1층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_1층 : TriggerState {
            internal State감지_1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetEffect(arg1: new[] {8002, 8003, 8004}, arg2: true);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 1);
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetActor(arg1: 9901, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(arg1: 9902, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9903, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9904, arg2: true, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.AddBuff(arg1: new[] {916}, arg2: 70002103, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(arg1: new[] {912})) {
                    return new State감지_2층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_2층 : TriggerState {
            internal State감지_2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8002}, arg2: false);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 1);
                context.AddBuff(arg1: new[] {916}, arg2: 70002103, arg3: 1, arg5: false);
                context.SetActor(arg1: 9902, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(arg1: new[] {913})) {
                    return new State감지_3층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_3층 : TriggerState {
            internal State감지_3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.AddBuff(arg1: new[] {916}, arg2: 70002103, arg3: 1, arg5: false);
                context.SetActor(arg1: 9903, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(arg1: new[] {914})) {
                    return new State감지_4층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_4층 : TriggerState {
            internal State감지_4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8004}, arg2: false);
                context.SetActor(arg1: 9904, arg2: true, arg3: "Interaction_Lapentafoothold_A01_On");
                context.AddBuff(arg1: new[] {916}, arg2: 70002105, arg3: 1, arg5: false);
                context.SetGravity(gravity: -32f);
                context.SetEventUI(arg1: 1, arg2: "$02020112_BF__BUTTONCHECK__0$", arg3: 5000);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 2);
                context.SetUserValue(triggerId: 99990001, key: "GravityRoom", value: 2);
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 1);
                context.SetActor(arg1: 9901, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9902, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9903, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(arg1: 9904, arg2: false, arg3: "Interaction_Lapentafoothold_A01_Off");
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(arg1: new[] {1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, arg2: false, arg3: 0, arg4: 20, arg5: 3f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}