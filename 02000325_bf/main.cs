using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000325_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000739, 10000740}, state: 2);
                context.SetEffect(triggerIds: new []{601, 602, 611, 612}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000752}, state: 0);
                context.SetInteractObject(interactIds: new []{13000009}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__0$", duration: 4000, boxId: 0);
                    return new State어나운스02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스02 : TriggerState {
            internal State어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__1$", duration: 3500, boxId: 0);
                    return new State어나운스03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스03 : TriggerState {
            internal State어나운스03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__2$", duration: 3500, boxId: 0);
                    return new State1라운드반응체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드반응체크 : TriggerState {
            internal State1라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000752}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000752}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{601}, visible: true);
                    return new State1라운드CountDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드CountDelay : TriggerState {
            internal State1라운드CountDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1라운드Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드Count : TriggerState {
            internal State1라운드Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602, 611, 612}, visible: true);
                context.SetInteractObject(interactIds: new []{10000739, 10000740}, state: 1);
                context.SetEventUI(arg1: 0, script: "1,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new State3001소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3002소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3003소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3004소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3005소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3006소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3007소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3008소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3009소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3010소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3011소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3012소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3013소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3014소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3015소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3016소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3017소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3018소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3019소환(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3020소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3001소환 : TriggerState {
            internal State3001소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001, 3001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3001})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3002소환 : TriggerState {
            internal State3002소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002, 3002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3002})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3003소환 : TriggerState {
            internal State3003소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003, 3003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3003})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3004소환 : TriggerState {
            internal State3004소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2004, 3004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3004})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3005소환 : TriggerState {
            internal State3005소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005, 3005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3005})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3006소환 : TriggerState {
            internal State3006소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006, 3006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3006})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3007소환 : TriggerState {
            internal State3007소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2007, 3007}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3007})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3008소환 : TriggerState {
            internal State3008소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2008, 3008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3008})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3009소환 : TriggerState {
            internal State3009소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2009, 3009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3009})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3010소환 : TriggerState {
            internal State3010소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2010, 3010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3010})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3011소환 : TriggerState {
            internal State3011소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011, 3011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3011})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3012소환 : TriggerState {
            internal State3012소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2012, 3012}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3012})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3013소환 : TriggerState {
            internal State3013소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2013, 3013}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3013})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3014소환 : TriggerState {
            internal State3014소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2014, 3014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3014})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3015소환 : TriggerState {
            internal State3015소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2015, 3015}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3015})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3016소환 : TriggerState {
            internal State3016소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2016, 3016}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3016})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3017소환 : TriggerState {
            internal State3017소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2017, 3017}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3017})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3018소환 : TriggerState {
            internal State3018소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2018, 3018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3018})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3019소환 : TriggerState {
            internal State3019소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2019, 3019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3019})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3020소환 : TriggerState {
            internal State3020소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2020, 3020}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3020})) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드Wait : TriggerState {
            internal State2라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000739, 10000740}, state: 2);
                context.SetEffect(triggerIds: new []{601, 611, 612}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State어나운스04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스04 : TriggerState {
            internal State어나운스04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__4$", duration: 3500, boxId: 0);
                    return new State2라운드반응체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드반응체크 : TriggerState {
            internal State2라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000752}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000752}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{601}, visible: true);
                    return new State어나운스04_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스04_2 : TriggerState {
            internal State어나운스04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__5$", duration: 3500, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2라운드Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드Count : TriggerState {
            internal State2라운드Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602, 612}, visible: true);
                context.SetInteractObject(interactIds: new []{10000740}, state: 1);
                context.SetEventUI(arg1: 0, script: "2,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__6$", stage: 2, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new State3001SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3002SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3003SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3004SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3005SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3006SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3007SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3008SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3009SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3010SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3011SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3012SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3013SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3014SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3015SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3016SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3017SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3018SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3019SummonCheck(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3020SummonCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3001SummonCheck : TriggerState {
            internal State3001SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2001})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2001})) {
                    return new State3001소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3002SummonCheck : TriggerState {
            internal State3002SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2002})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2002})) {
                    return new State3002소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3003SummonCheck : TriggerState {
            internal State3003SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2003})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2003})) {
                    return new State3003소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3004SummonCheck : TriggerState {
            internal State3004SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2004})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2004})) {
                    return new State3004소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3005SummonCheck : TriggerState {
            internal State3005SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2005})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2005})) {
                    return new State3005소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3006SummonCheck : TriggerState {
            internal State3006SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2006})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2006})) {
                    return new State3006소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3007SummonCheck : TriggerState {
            internal State3007SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2007})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2007})) {
                    return new State3007소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3008SummonCheck : TriggerState {
            internal State3008SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2008})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2008})) {
                    return new State3008소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3009SummonCheck : TriggerState {
            internal State3009SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2009})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2009})) {
                    return new State3009소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3010SummonCheck : TriggerState {
            internal State3010SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2010})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2010})) {
                    return new State3010소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3011SummonCheck : TriggerState {
            internal State3011SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2011})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2011})) {
                    return new State3011소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3012SummonCheck : TriggerState {
            internal State3012SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2012})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2012})) {
                    return new State3012소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3013SummonCheck : TriggerState {
            internal State3013SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2013})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2013})) {
                    return new State3013소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3014SummonCheck : TriggerState {
            internal State3014SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2014})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2014})) {
                    return new State3014소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3015SummonCheck : TriggerState {
            internal State3015SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2015})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2015})) {
                    return new State3015소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3016SummonCheck : TriggerState {
            internal State3016SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2016})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2016})) {
                    return new State3016소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3017SummonCheck : TriggerState {
            internal State3017SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2017})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2017})) {
                    return new State3017소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3018SummonCheck : TriggerState {
            internal State3018SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2018})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2018})) {
                    return new State3018소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3019SummonCheck : TriggerState {
            internal State3019SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2019})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2019})) {
                    return new State3019소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3020SummonCheck : TriggerState {
            internal State3020SummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2020})) {
                    return new State2라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2020})) {
                    return new State3020소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3001소환2 : TriggerState {
            internal State3001소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001, 3001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3001})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3002소환2 : TriggerState {
            internal State3002소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002, 3002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3002})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3003소환2 : TriggerState {
            internal State3003소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003, 3003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3003})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3004소환2 : TriggerState {
            internal State3004소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2004, 3004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3004})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3005소환2 : TriggerState {
            internal State3005소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005, 3005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3005})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3006소환2 : TriggerState {
            internal State3006소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006, 3006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3006})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3007소환2 : TriggerState {
            internal State3007소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2007, 3007}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3007})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3008소환2 : TriggerState {
            internal State3008소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2008, 3008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3008})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3009소환2 : TriggerState {
            internal State3009소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2009, 3009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3009})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3010소환2 : TriggerState {
            internal State3010소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2010, 3010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3010})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3011소환2 : TriggerState {
            internal State3011소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011, 3011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3011})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3012소환2 : TriggerState {
            internal State3012소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2012, 3012}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3012})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3013소환2 : TriggerState {
            internal State3013소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2013, 3013}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3013})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3014소환2 : TriggerState {
            internal State3014소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2014, 3014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3014})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3015소환2 : TriggerState {
            internal State3015소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2015, 3015}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3015})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3016소환2 : TriggerState {
            internal State3016소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2016, 3016}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3016})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3017소환2 : TriggerState {
            internal State3017소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2017, 3017}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3017})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3018소환2 : TriggerState {
            internal State3018소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2018, 3018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3018})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3019소환2 : TriggerState {
            internal State3019소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2019, 3019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3019})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3020소환2 : TriggerState {
            internal State3020소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2020, 3020}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3020})) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드Wait : TriggerState {
            internal State3라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 612}, visible: false);
                context.SetInteractObject(interactIds: new []{10000740}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State어나운스05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스05 : TriggerState {
            internal State어나운스05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$02000325_BF__MAIN__7$", duration: 3500, boxId: 0);
                    return new State3라운드반응체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드반응체크 : TriggerState {
            internal State3라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000752}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000752}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{601}, visible: true);
                    return new State3라운드Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드Count : TriggerState {
            internal State3라운드Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetEffect(triggerIds: new []{612}, visible: false);
                context.SetEventUI(arg1: 0, script: "3,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__9$", stage: 3, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3라운드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new State3001SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3002SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3003SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3004SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3005SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3006SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3007SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3008SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3009SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3010SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3011SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3012SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3013SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3014SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3015SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3016SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3017SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3018SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3019SummonCheck2(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new State3020SummonCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3001SummonCheck2 : TriggerState {
            internal State3001SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2001})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2001})) {
                    return new State3001소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3002SummonCheck2 : TriggerState {
            internal State3002SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2002})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2002})) {
                    return new State3002소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3003SummonCheck2 : TriggerState {
            internal State3003SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2003})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2003})) {
                    return new State3003소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3004SummonCheck2 : TriggerState {
            internal State3004SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2004})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2004})) {
                    return new State3004소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3005SummonCheck2 : TriggerState {
            internal State3005SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2005})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2005})) {
                    return new State3005소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3006SummonCheck2 : TriggerState {
            internal State3006SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2006})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2006})) {
                    return new State3006소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3007SummonCheck2 : TriggerState {
            internal State3007SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2007})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2007})) {
                    return new State3007소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3008SummonCheck2 : TriggerState {
            internal State3008SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2008})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2008})) {
                    return new State3008소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3009SummonCheck2 : TriggerState {
            internal State3009SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2009})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2009})) {
                    return new State3009소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3010SummonCheck2 : TriggerState {
            internal State3010SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2010})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2010})) {
                    return new State3010소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3011SummonCheck2 : TriggerState {
            internal State3011SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2011})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2011})) {
                    return new State3011소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3012SummonCheck2 : TriggerState {
            internal State3012SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2012})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2012})) {
                    return new State3012소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3013SummonCheck2 : TriggerState {
            internal State3013SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2013})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2013})) {
                    return new State3013소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3014SummonCheck2 : TriggerState {
            internal State3014SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2014})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2014})) {
                    return new State3014소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3015SummonCheck2 : TriggerState {
            internal State3015SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2015})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2015})) {
                    return new State3015소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3016SummonCheck2 : TriggerState {
            internal State3016SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2016})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2016})) {
                    return new State3016소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3017SummonCheck2 : TriggerState {
            internal State3017SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2017})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2017})) {
                    return new State3017소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3018SummonCheck2 : TriggerState {
            internal State3018SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2018})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2018})) {
                    return new State3018소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3019SummonCheck2 : TriggerState {
            internal State3019SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2019})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2019})) {
                    return new State3019소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3020SummonCheck2 : TriggerState {
            internal State3020SummonCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 199, spawnIds: new []{2020})) {
                    return new State3라운드(context);
                }

                if (!context.NpcDetected(boxId: 199, spawnIds: new []{2020})) {
                    return new State3020소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3001소환3 : TriggerState {
            internal State3001소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001, 3001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3001})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3002소환3 : TriggerState {
            internal State3002소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002, 3002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3002})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3003소환3 : TriggerState {
            internal State3003소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003, 3003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3003})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3004소환3 : TriggerState {
            internal State3004소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2004, 3004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3004})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3005소환3 : TriggerState {
            internal State3005소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005, 3005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3005})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3006소환3 : TriggerState {
            internal State3006소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006, 3006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3006})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3007소환3 : TriggerState {
            internal State3007소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2007, 3007}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3007})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3008소환3 : TriggerState {
            internal State3008소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2008, 3008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3008})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3009소환3 : TriggerState {
            internal State3009소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2009, 3009}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3009})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3010소환3 : TriggerState {
            internal State3010소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2010, 3010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3010})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3011소환3 : TriggerState {
            internal State3011소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011, 3011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3011})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3012소환3 : TriggerState {
            internal State3012소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2012, 3012}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3012})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3013소환3 : TriggerState {
            internal State3013소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2013, 3013}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3013})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3014소환3 : TriggerState {
            internal State3014소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2014, 3014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3014})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3015소환3 : TriggerState {
            internal State3015소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2015, 3015}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3015})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3016소환3 : TriggerState {
            internal State3016소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2016, 3016}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3016})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3017소환3 : TriggerState {
            internal State3017소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2017, 3017}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3017})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3018소환3 : TriggerState {
            internal State3018소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2018, 3018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3018})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3019소환3 : TriggerState {
            internal State3019소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2019, 3019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3019})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3020소환3 : TriggerState {
            internal State3020소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2020, 3020}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3020})) {
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션Success : TriggerState {
            internal State미션Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 102, type: "trigger", code: "BraveRace");
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
                context.SetEffect(triggerIds: new []{601, 612}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3라운드보상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드보상 : TriggerState {
            internal State3라운드보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.SetEventUI(arg1: 0, script: "0,0");
                    context.DungeonClear();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
