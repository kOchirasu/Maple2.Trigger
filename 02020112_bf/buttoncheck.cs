namespace Maple2.Trigger._02020112_bf {
    public static class _buttoncheck {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 9901, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9902, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9903, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9904, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 0);
                context.AddBuff(boxIds: new []{916}, skillId: 70002104, level: 1, arg5: false);
                context.SetEffect(triggerIds: new []{8001}, visible: true);
                context.SetEffect(triggerIds: new []{8002, 8003, 8004}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.AddBuff(boxIds: new []{916}, skillId: 70002104, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{911})) {
                    return new State감지_1층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_1층 : TriggerState {
            internal State감지_1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: false);
                context.SetEffect(triggerIds: new []{8002, 8003, 8004}, visible: true);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 1);
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, visible: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, visible: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, visible: true, arg3: 0, arg4: 20, arg5: 3f);
                context.SetActor(triggerId: 9901, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.SetActor(triggerId: 9902, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9903, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9904, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.AddBuff(boxIds: new []{916}, skillId: 70002103, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{912})) {
                    return new State감지_2층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_2층 : TriggerState {
            internal State감지_2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8002}, visible: false);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 1);
                context.AddBuff(boxIds: new []{916}, skillId: 70002103, level: 1, arg5: false);
                context.SetActor(triggerId: 9902, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{913})) {
                    return new State감지_3층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_3층 : TriggerState {
            internal State감지_3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8003}, visible: false);
                context.AddBuff(boxIds: new []{916}, skillId: 70002103, level: 1, arg5: false);
                context.SetActor(triggerId: 9903, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{914})) {
                    return new State감지_4층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지_4층 : TriggerState {
            internal State감지_4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8004}, visible: false);
                context.SetActor(triggerId: 9904, visible: true, initialSequence: "Interaction_Lapentafoothold_A01_On");
                context.AddBuff(boxIds: new []{916}, skillId: 70002105, level: 1, arg5: false);
                context.SetGravity(gravity: -32f);
                context.SetEventUI(arg1: 1, script: "$02020112_BF__BUTTONCHECK__0$", duration: 5000);
                context.SetUserValue(triggerId: 99990016, key: "respawn", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 2);
                context.SetUserValue(triggerId: 99990001, key: "GravityRoom", value: 2);
                context.SetUserValue(triggerId: 99990021, key: "Reconnect", value: 1);
                context.SetActor(triggerId: 9901, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9902, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9903, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetActor(triggerId: 9904, visible: false, initialSequence: "Interaction_Lapentafoothold_A01_Off");
                context.SetMesh(triggerIds: new []{1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
                context.SetMesh(triggerIds: new []{1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660}, visible: false, arg3: 0, arg4: 20, arg5: 3f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
