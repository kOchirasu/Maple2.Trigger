using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000325_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10000739}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000740}, arg2: 2);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000752}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {13000009}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__0$", arg3: new int[] {4000}, arg4: "0");
                    context.State = new State어나운스02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스02 : TriggerState {
            internal State어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__1$", arg3: new int[] {3500}, arg4: "0");
                    context.State = new State어나운스03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스03 : TriggerState {
            internal State어나운스03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__2$", arg3: new int[] {3500}, arg4: "0");
                    context.State = new State1라운드반응체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드반응체크 : TriggerState {
            internal State1라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000752}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000752}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.State = new State1라운드카운트딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드카운트딜레이 : TriggerState {
            internal State1라운드카운트딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1라운드카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드카운트 : TriggerState {
            internal State1라운드카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {611}, arg2: true);
                context.SetEffect(arg1: new int[] {612}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000739}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000740}, arg2: 1);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3001소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3002소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3003소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3004소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3005소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3006소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3007소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3008소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3009소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3010소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3011소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3012소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3013소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3014소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3015소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3016소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3017소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3018소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3019소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3020소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3001소환 : TriggerState {
            internal State3001소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {3001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3001})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3002소환 : TriggerState {
            internal State3002소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {3002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3002})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3003소환 : TriggerState {
            internal State3003소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {3003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3003})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3004소환 : TriggerState {
            internal State3004소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.CreateMonster(arg1: new int[] {3004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3004})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3005소환 : TriggerState {
            internal State3005소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
                context.CreateMonster(arg1: new int[] {3005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3005})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3006소환 : TriggerState {
            internal State3006소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2006}, arg2: false);
                context.CreateMonster(arg1: new int[] {3006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3006})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3007소환 : TriggerState {
            internal State3007소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2007}, arg2: false);
                context.CreateMonster(arg1: new int[] {3007}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3007})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3008소환 : TriggerState {
            internal State3008소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2008}, arg2: false);
                context.CreateMonster(arg1: new int[] {3008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3008})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3009소환 : TriggerState {
            internal State3009소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2009}, arg2: false);
                context.CreateMonster(arg1: new int[] {3009}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3009})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3010소환 : TriggerState {
            internal State3010소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2010}, arg2: false);
                context.CreateMonster(arg1: new int[] {3010}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3010})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3011소환 : TriggerState {
            internal State3011소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2011}, arg2: false);
                context.CreateMonster(arg1: new int[] {3011}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3011})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3012소환 : TriggerState {
            internal State3012소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2012}, arg2: false);
                context.CreateMonster(arg1: new int[] {3012}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3012})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3013소환 : TriggerState {
            internal State3013소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2013}, arg2: false);
                context.CreateMonster(arg1: new int[] {3013}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3013})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3014소환 : TriggerState {
            internal State3014소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2014}, arg2: false);
                context.CreateMonster(arg1: new int[] {3014}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3014})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3015소환 : TriggerState {
            internal State3015소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2015}, arg2: false);
                context.CreateMonster(arg1: new int[] {3015}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3015})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3016소환 : TriggerState {
            internal State3016소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2016}, arg2: false);
                context.CreateMonster(arg1: new int[] {3016}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3016})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3017소환 : TriggerState {
            internal State3017소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2017}, arg2: false);
                context.CreateMonster(arg1: new int[] {3017}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3017})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3018소환 : TriggerState {
            internal State3018소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2018}, arg2: false);
                context.CreateMonster(arg1: new int[] {3018}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3018})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3019소환 : TriggerState {
            internal State3019소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2019}, arg2: false);
                context.CreateMonster(arg1: new int[] {3019}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3019})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3020소환 : TriggerState {
            internal State3020소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2020}, arg2: false);
                context.CreateMonster(arg1: new int[] {3020}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3020})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드대기 : TriggerState {
            internal State2라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000739}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000740}, arg2: 2);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State어나운스04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스04 : TriggerState {
            internal State어나운스04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__4$", arg3: new int[] {3500}, arg4: "0");
                    context.State = new State2라운드반응체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드반응체크 : TriggerState {
            internal State2라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000752}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000752}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.State = new State어나운스04_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스04_2 : TriggerState {
            internal State어나운스04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__5$", arg3: new int[] {3500}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2라운드카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드카운트 : TriggerState {
            internal State2라운드카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {612}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000740}, arg2: 1);
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__6$", stage: 2, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3001소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3002소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3003소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3004소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3005소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3006소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3007소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3008소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3009소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3010소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3011소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3012소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3013소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3014소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3015소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3016소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3017소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3018소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3019소환체크(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3020소환체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3001소환체크 : TriggerState {
            internal State3001소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2001})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2001})) {
                    context.State = new State3001소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3002소환체크 : TriggerState {
            internal State3002소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2002})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2002})) {
                    context.State = new State3002소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3003소환체크 : TriggerState {
            internal State3003소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2003})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2003})) {
                    context.State = new State3003소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3004소환체크 : TriggerState {
            internal State3004소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2004})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2004})) {
                    context.State = new State3004소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3005소환체크 : TriggerState {
            internal State3005소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2005})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2005})) {
                    context.State = new State3005소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3006소환체크 : TriggerState {
            internal State3006소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2006})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2006})) {
                    context.State = new State3006소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3007소환체크 : TriggerState {
            internal State3007소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2007})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2007})) {
                    context.State = new State3007소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3008소환체크 : TriggerState {
            internal State3008소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2008})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2008})) {
                    context.State = new State3008소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3009소환체크 : TriggerState {
            internal State3009소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2009})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2009})) {
                    context.State = new State3009소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3010소환체크 : TriggerState {
            internal State3010소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2010})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2010})) {
                    context.State = new State3010소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3011소환체크 : TriggerState {
            internal State3011소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2011})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2011})) {
                    context.State = new State3011소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3012소환체크 : TriggerState {
            internal State3012소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2012})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2012})) {
                    context.State = new State3012소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3013소환체크 : TriggerState {
            internal State3013소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2013})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2013})) {
                    context.State = new State3013소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3014소환체크 : TriggerState {
            internal State3014소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2014})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2014})) {
                    context.State = new State3014소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3015소환체크 : TriggerState {
            internal State3015소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2015})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2015})) {
                    context.State = new State3015소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3016소환체크 : TriggerState {
            internal State3016소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2016})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2016})) {
                    context.State = new State3016소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3017소환체크 : TriggerState {
            internal State3017소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2017})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2017})) {
                    context.State = new State3017소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3018소환체크 : TriggerState {
            internal State3018소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2018})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2018})) {
                    context.State = new State3018소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3019소환체크 : TriggerState {
            internal State3019소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2019})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2019})) {
                    context.State = new State3019소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3020소환체크 : TriggerState {
            internal State3020소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2020})) {
                    context.State = new State2라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2020})) {
                    context.State = new State3020소환2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3001소환2 : TriggerState {
            internal State3001소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {3001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3001})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3002소환2 : TriggerState {
            internal State3002소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {3002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3002})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3003소환2 : TriggerState {
            internal State3003소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {3003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3003})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3004소환2 : TriggerState {
            internal State3004소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.CreateMonster(arg1: new int[] {3004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3004})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3005소환2 : TriggerState {
            internal State3005소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
                context.CreateMonster(arg1: new int[] {3005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3005})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3006소환2 : TriggerState {
            internal State3006소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2006}, arg2: false);
                context.CreateMonster(arg1: new int[] {3006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3006})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3007소환2 : TriggerState {
            internal State3007소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2007}, arg2: false);
                context.CreateMonster(arg1: new int[] {3007}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3007})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3008소환2 : TriggerState {
            internal State3008소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2008}, arg2: false);
                context.CreateMonster(arg1: new int[] {3008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3008})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3009소환2 : TriggerState {
            internal State3009소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2009}, arg2: false);
                context.CreateMonster(arg1: new int[] {3009}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3009})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3010소환2 : TriggerState {
            internal State3010소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2010}, arg2: false);
                context.CreateMonster(arg1: new int[] {3010}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3010})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3011소환2 : TriggerState {
            internal State3011소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2011}, arg2: false);
                context.CreateMonster(arg1: new int[] {3011}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3011})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3012소환2 : TriggerState {
            internal State3012소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2012}, arg2: false);
                context.CreateMonster(arg1: new int[] {3012}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3012})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3013소환2 : TriggerState {
            internal State3013소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2013}, arg2: false);
                context.CreateMonster(arg1: new int[] {3013}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3013})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3014소환2 : TriggerState {
            internal State3014소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2014}, arg2: false);
                context.CreateMonster(arg1: new int[] {3014}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3014})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3015소환2 : TriggerState {
            internal State3015소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2015}, arg2: false);
                context.CreateMonster(arg1: new int[] {3015}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3015})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3016소환2 : TriggerState {
            internal State3016소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2016}, arg2: false);
                context.CreateMonster(arg1: new int[] {3016}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3016})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3017소환2 : TriggerState {
            internal State3017소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2017}, arg2: false);
                context.CreateMonster(arg1: new int[] {3017}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3017})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3018소환2 : TriggerState {
            internal State3018소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2018}, arg2: false);
                context.CreateMonster(arg1: new int[] {3018}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3018})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3019소환2 : TriggerState {
            internal State3019소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2019}, arg2: false);
                context.CreateMonster(arg1: new int[] {3019}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3019})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3020소환2 : TriggerState {
            internal State3020소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2020}, arg2: false);
                context.CreateMonster(arg1: new int[] {3020}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3020})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드대기 : TriggerState {
            internal State3라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000740}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State어나운스05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어나운스05 : TriggerState {
            internal State어나운스05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000325_BF__MAIN__7$", arg3: new int[] {3500}, arg4: "0");
                    context.State = new State3라운드반응체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드반응체크 : TriggerState {
            internal State3라운드반응체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000752}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000752}, arg2: 0)) {
                    context.SetEffect(arg1: new int[] {601}, arg2: true);
                    context.State = new State3라운드카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드카운트 : TriggerState {
            internal State3라운드카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.ShowCountUI(text: "$02000325_BF__MAIN__9$", stage: 3, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3001소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3002소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3003소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3004소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3005소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3006소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3007소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3008소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3009소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3010소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3011소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3012소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3013소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3014소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3015소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3016소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3017소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3018소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3019소환체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new State3020소환체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3001소환체크2 : TriggerState {
            internal State3001소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2001})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2001})) {
                    context.State = new State3001소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3002소환체크2 : TriggerState {
            internal State3002소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2002})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2002})) {
                    context.State = new State3002소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3003소환체크2 : TriggerState {
            internal State3003소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2003})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2003})) {
                    context.State = new State3003소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3004소환체크2 : TriggerState {
            internal State3004소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2004})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2004})) {
                    context.State = new State3004소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3005소환체크2 : TriggerState {
            internal State3005소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2005})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2005})) {
                    context.State = new State3005소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3006소환체크2 : TriggerState {
            internal State3006소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2006})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2006})) {
                    context.State = new State3006소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3007소환체크2 : TriggerState {
            internal State3007소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2007})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2007})) {
                    context.State = new State3007소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3008소환체크2 : TriggerState {
            internal State3008소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2008})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2008})) {
                    context.State = new State3008소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3009소환체크2 : TriggerState {
            internal State3009소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2009})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2009})) {
                    context.State = new State3009소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3010소환체크2 : TriggerState {
            internal State3010소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2010})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2010})) {
                    context.State = new State3010소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3011소환체크2 : TriggerState {
            internal State3011소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2011})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2011})) {
                    context.State = new State3011소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3012소환체크2 : TriggerState {
            internal State3012소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2012})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2012})) {
                    context.State = new State3012소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3013소환체크2 : TriggerState {
            internal State3013소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2013})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2013})) {
                    context.State = new State3013소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3014소환체크2 : TriggerState {
            internal State3014소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2014})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2014})) {
                    context.State = new State3014소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3015소환체크2 : TriggerState {
            internal State3015소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2015})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2015})) {
                    context.State = new State3015소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3016소환체크2 : TriggerState {
            internal State3016소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2016})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2016})) {
                    context.State = new State3016소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3017소환체크2 : TriggerState {
            internal State3017소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2017})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2017})) {
                    context.State = new State3017소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3018소환체크2 : TriggerState {
            internal State3018소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2018})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2018})) {
                    context.State = new State3018소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3019소환체크2 : TriggerState {
            internal State3019소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2019})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2019})) {
                    context.State = new State3019소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3020소환체크2 : TriggerState {
            internal State3020소환체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 199, arg2: new int[] {2020})) {
                    context.State = new State3라운드(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 199, arg2: new int[] {2020})) {
                    context.State = new State3020소환3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3001소환3 : TriggerState {
            internal State3001소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {3001}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3001})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3002소환3 : TriggerState {
            internal State3002소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {3002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3002})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3003소환3 : TriggerState {
            internal State3003소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {3003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3003})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3004소환3 : TriggerState {
            internal State3004소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.CreateMonster(arg1: new int[] {3004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3004})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3005소환3 : TriggerState {
            internal State3005소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
                context.CreateMonster(arg1: new int[] {3005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3005})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3006소환3 : TriggerState {
            internal State3006소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2006}, arg2: false);
                context.CreateMonster(arg1: new int[] {3006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3006})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3007소환3 : TriggerState {
            internal State3007소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2007}, arg2: false);
                context.CreateMonster(arg1: new int[] {3007}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3007})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3008소환3 : TriggerState {
            internal State3008소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2008}, arg2: false);
                context.CreateMonster(arg1: new int[] {3008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3008})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3009소환3 : TriggerState {
            internal State3009소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2009}, arg2: false);
                context.CreateMonster(arg1: new int[] {3009}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3009})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3010소환3 : TriggerState {
            internal State3010소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2010}, arg2: false);
                context.CreateMonster(arg1: new int[] {3010}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3010})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3011소환3 : TriggerState {
            internal State3011소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2011}, arg2: false);
                context.CreateMonster(arg1: new int[] {3011}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3011})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3012소환3 : TriggerState {
            internal State3012소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2012}, arg2: false);
                context.CreateMonster(arg1: new int[] {3012}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3012})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3013소환3 : TriggerState {
            internal State3013소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2013}, arg2: false);
                context.CreateMonster(arg1: new int[] {3013}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3013})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3014소환3 : TriggerState {
            internal State3014소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2014}, arg2: false);
                context.CreateMonster(arg1: new int[] {3014}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3014})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3015소환3 : TriggerState {
            internal State3015소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2015}, arg2: false);
                context.CreateMonster(arg1: new int[] {3015}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3015})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3016소환3 : TriggerState {
            internal State3016소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2016}, arg2: false);
                context.CreateMonster(arg1: new int[] {3016}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3016})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3017소환3 : TriggerState {
            internal State3017소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2017}, arg2: false);
                context.CreateMonster(arg1: new int[] {3017}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3017})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3018소환3 : TriggerState {
            internal State3018소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2018}, arg2: false);
                context.CreateMonster(arg1: new int[] {3018}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3018})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3019소환3 : TriggerState {
            internal State3019소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2019}, arg2: false);
                context.CreateMonster(arg1: new int[] {3019}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3019})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3020소환3 : TriggerState {
            internal State3020소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2020}, arg2: false);
                context.CreateMonster(arg1: new int[] {3020}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3020})) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미션성공 : TriggerState {
            internal State미션성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "BraveRace");
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3라운드보상(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드보상 : TriggerState {
            internal State3라운드보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.SetEventUI(arg1: 0, arg2: "0,0");
                    context.DungeonClear();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}